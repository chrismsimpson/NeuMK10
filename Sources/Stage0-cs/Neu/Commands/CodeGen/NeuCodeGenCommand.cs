
namespace Neu;

public class NeuCodeGenCommand: ICommand {

    public NeuCodeGenCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            // var s = new NeuSource();

            ///

            WriteLine($"Hello code gen!");
        });
    }
}