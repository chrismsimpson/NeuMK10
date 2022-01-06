
namespace Neu;

public class NeuInteractiveCommand: ICommand {

    public NeuInteractiveCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            throw new Exception();
        });
    }
}