
namespace Neu;

public partial class NeuSizeOfTestCommand: NeuTestsCommand {
    
    public NeuSizeOfTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            this.ZipAssertSourceOutput(new dynamic[] { 4, 1, 4 });

            ///

            WriteSuccessMessage(arguments);
        });
    }
}