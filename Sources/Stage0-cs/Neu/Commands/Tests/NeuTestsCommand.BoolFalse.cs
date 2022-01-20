
namespace Neu;

public partial class NeuBoolFalseTestCommand: NeuTestsCommand {

    public NeuBoolFalseTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            var boolResult = result as NeuBool;

            if (boolResult == null) {

                throw new Exception();
            }

            ///

            if (boolResult.Value != false) {
                
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
