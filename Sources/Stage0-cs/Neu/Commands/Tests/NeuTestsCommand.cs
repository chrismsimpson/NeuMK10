
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

    public (String Filename, NeuOperation? Result) Evaluate(
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

        var silent = arguments.Get("--silent") == null
            ? false
            : true;

        if (!silent) {
        
            WriteLine($"///////////////////////////////////////////////\n");
        }

        ///

        var dumpAST = arguments.Get("--dump-ast") is String;

        ///

        if (silent) {

            dumpAST = false;
        }

        ///

        if (!silent) {

            WriteLine($"  Running test {filename}{(dumpAST ? "\n" : "")}");
        }

        var result = interpreter.Evaluate(filename, droppedArgs, dumpAST: dumpAST, indent: 2);

        ///

        if (!silent) {
        
            WriteLine($"  Result: {result.Dump()}");
        }

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

        await new NeuVariableTestCommand()
            .Run(filename: "./Tests/Neu/test04.neu", args);

        await new NeuPostfixIncrementTestCommand()
            .Run(filename: "./Tests/Neu/test05.neu", args);

        await new NeuPostfixDecrementTestCommand()
            .Run(filename: "./Tests/Neu/test06.neu", args);

        await new NeuPrefixIncrementTestCommand()
            .Run(filename: "./Tests/Neu/test07.neu", args);

        await new NeuPrefixDecrementTestCommand()
            .Run(filename: "./Tests/Neu/test08.neu", args);

        await new NeuBoolTrueTestCommand()
            .Run(filename: "./Tests/Neu/test09.neu", args);

        await new NeuBoolFalseTestCommand()
            .Run(filename: "./Tests/Neu/test10.neu", args);


        await new NeuFooTestCommand()
            .Run(filename: "./Tests/Neu/testN.neu", args);
    }
}