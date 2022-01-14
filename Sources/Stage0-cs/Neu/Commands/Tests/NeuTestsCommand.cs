
namespace Neu;

public class NeuTestsCommand: ICommand {

    public NeuTestsCommand() { }

    ///

    public async Task Run(
        String filename,
        IEnumerable<IArgument> arguments) {

        var args = new List<String>();

        args.Add("neu");

        args.Add(filename);

        var n = arguments.ToArgs();

        args.AddRange(n);

        var a = args.ToArguments();

        await this.Run(a);
    }

    public async Task Run(
        params String[] args) {

        await this.Run(args.ToArguments());
    }

    public (String Filename, NeuValue? Value) Evaluate(
        IEnumerable<IArgument> arguments) {

        var interpreter = new NeuInterpreter();

        ///

        var droppedArgs = arguments.DropArguments(number: 1);

        ///

        var filename = droppedArgs.GetFirstArgumentSource();

        if (IsNullOrWhiteSpace(filename)) {

            throw new Exception();
        }

        ///

        WriteLine($"///////////////////////////////////////////////\n");

        ///

        var dumpAST = arguments.Get("--dump-ast") is String;

        ///

        WriteLine($"  Running test {filename}{(dumpAST ? "\n" : "")}");

        var result = interpreter.Evaluate(filename, droppedArgs, dumpAST: dumpAST, indent: 2);

        ///

        WriteLine($"  Result: {result.Dump()}");

        ///

        return (filename, result);
    }

    public virtual async Task Run(
        IEnumerable<IArgument> arguments) {

        var args = arguments.DropArguments(number: 1);

        await new NeuTestsVoidCommand()
            .Run(filename: "./Tests/Neu/test00.neu", args);

        await new NeuTestsBasicIntFuncCommand()
            .Run(filename: "./Tests/Neu/test01.neu", args);

        await new NeuTestsBasicFloatFuncCommand()
            .Run(filename: "./Tests/Neu/test02.neu", args);

        await new NeuArithmeticTestCommand()
            .Run(filename: "./Tests/Neu/test03.neu", args);
    }
}