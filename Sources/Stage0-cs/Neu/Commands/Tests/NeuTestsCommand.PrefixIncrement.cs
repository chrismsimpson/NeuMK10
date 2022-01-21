
namespace Neu;

public partial class NeuPrefixIncrementTestCommand: NeuTestsCommand {

    public NeuPrefixIncrementTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            var intResult = result as NeuInteger;

            if (intResult == null) {

                throw new Exception();
            }

            ///

            if (intResult.Value != 1) {
                
                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}
