
namespace Neu;

public class NeuBuildCommand: ICommand {

    public NeuBuildCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            throw new Exception();
        });
    }
}