
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

            var silent = arguments.Get("--silent") == null
                ? false
                : true;

            if (!silent) {
            
                WriteLine($"  Test {filename} successful\n");
            }
        });
    }
}