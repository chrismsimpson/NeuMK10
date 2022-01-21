
namespace Neu;

public class NeuTestsBasicFloatFuncCommand: NeuTestsCommand {

    public NeuTestsBasicFloatFuncCommand() { }

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

            if (floatResult.Value != 0.0) {

                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}