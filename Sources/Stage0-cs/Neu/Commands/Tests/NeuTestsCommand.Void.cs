
namespace Neu;

public class NeuTestsVoidCommand: NeuTestsCommand {

    public NeuTestsVoidCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

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