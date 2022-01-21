
namespace Neu;

public partial class NeuPostfixDecrementTestCommand: NeuTestsCommand {

    public NeuPostfixDecrementTestCommand() { }

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

            if (intResult.Value != 2) {
                
                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}
