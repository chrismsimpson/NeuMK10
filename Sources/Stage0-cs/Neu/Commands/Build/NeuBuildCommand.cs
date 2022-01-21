
namespace Neu;

public class NeuBuildCommand: ICommand {

    public NeuBuildCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var path = "./Sources/Stage1";

            foreach (var n in GetFiles(path)) {

                WriteLine(n);
            }

            

            WriteLine("Hello build!");
        });
    }
}