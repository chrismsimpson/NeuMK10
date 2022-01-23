
namespace Neu;

public class NeuRunCommand: ICommand {

    public NeuRunCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            WriteLine($"hello run!");
        });
    }
}