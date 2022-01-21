
namespace Neu;

public partial class NeuBoolTrueTestCommand: NeuTestsCommand {

    public NeuBoolTrueTestCommand() { }

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

            if (boolResult.Value != true) {
                
                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}
