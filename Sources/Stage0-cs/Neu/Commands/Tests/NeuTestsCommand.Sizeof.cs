
namespace Neu;

public partial class NeuSizeOfTestCommand: NeuTestsCommand {
    
    public NeuSizeOfTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            this.ZipAssertSourceOutput(new dynamic[] {
                
                ((int) 4), 
                ((int) 1), 
                ((int) 4)
            });

            ///

            WriteSuccessMessage(arguments);
        });
    }
}