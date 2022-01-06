
namespace Neu;

public class NeuTestsBasicIntFuncCommand: NeuTestsCommand {

    public NeuTestsBasicIntFuncCommand() { }

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

            WriteLine($"////////////////////////////////\n");

            WriteLine($"// Running test {filename}\n");

            ///

            var result = interpreter.Evaluate(filename, droppedArgs, dumpAST: true);

            ///

            WriteLine($"Result: {result.Dump()}\n");

            ///

            var intResult = result as NeuInteger;

            if (intResult == null) {

                throw new Exception();
            }

            ///

            if (intResult.Value != 0) {

                throw new Exception();
            }

            ///

            WriteLine($"neu {arguments.GetArgumentSource(distance: 1)} successful\n");
        });
    }
}