
namespace Neu;

public partial class NeuFooTestCommand: NeuTestsCommand {
    
    public NeuFooTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            this.ZipAssertSourceOutput(new dynamic[] {
                
                ((int) 8),
                ((int) 3),
                ((float) 10 / 3)
            });

            ///

            WriteSuccessMessage(arguments);
        });
    }
}