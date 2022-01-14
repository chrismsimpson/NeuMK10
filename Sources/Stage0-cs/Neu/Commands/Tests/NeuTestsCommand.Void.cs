
namespace Neu;

public class NeuTestsVoidCommand: NeuTestsCommand {

    public NeuTestsVoidCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var interpreter = new NeuInterpreter();

            ///

            var droppedArgs = arguments.DropArguments(number: 1);

            ///

            var filename = droppedArgs.GetFirstArgumentSource();

            if (IsNullOrWhiteSpace(filename)) {

                throw new Exception();
            }

            ///

            WriteLine($"////////////////////////////////////////////////\n");

            ///

            var dumpAST = arguments.Get("--dump-ast") is String;

            ///

            WriteLine($"  Running test {filename}{(dumpAST ? "\n" : "")}");

            var result = interpreter.Evaluate(filename, droppedArgs, dumpAST: dumpAST, indent: 2);

            ///

            WriteLine($"  Result: {result.Dump()}");

            ///

            var voidResult = result as NeuVoid;

            if (voidResult == null) {

                throw new Exception();
            }

            ///

            WriteLine($"  Test {arguments.GetArgumentSource(distance: 1)} successful\n");
        });
    }
}