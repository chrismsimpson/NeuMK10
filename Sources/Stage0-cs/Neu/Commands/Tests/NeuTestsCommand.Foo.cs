
namespace Neu;

public partial class NeuFooTestCommand: NeuTestsCommand {
    
    public NeuFooTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            // WriteLine($"Result: {result?.Dump()}");
        });
    }
}