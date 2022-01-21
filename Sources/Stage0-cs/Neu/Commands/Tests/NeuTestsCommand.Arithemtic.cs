
namespace Neu;

public partial class NeuArithmeticTestCommand: NeuTestsCommand {

    public NeuArithmeticTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            var floatResult = result as NeuFloat;

            if (floatResult == null) {

                throw new Exception();
            }

            ///

            if (floatResult.Value != 2.5) {
                
                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}
