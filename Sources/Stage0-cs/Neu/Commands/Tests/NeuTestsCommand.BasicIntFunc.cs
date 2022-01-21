
namespace Neu;

public class NeuTestsBasicIntFuncCommand: NeuTestsCommand {

    public NeuTestsBasicIntFuncCommand() { }

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

            if (intResult.Value != 0) {

                throw new Exception();
            }

            ///

            WriteSuccessMessage(arguments);
        });
    }
}