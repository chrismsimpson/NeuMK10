
namespace Neu;

public class NeuTestsCommand: ICommand {

    public NeuTestsCommand() { }

    ///

    public async Task Run(
        String filename) {

        await this.Run((new [] { "neu", filename }).ToArguments());
    }

    public async Task Run(
        params String[] args) {

        await this.Run(args.ToArguments());
    }

    public virtual async Task Run(
        IEnumerable<IArgument> arguments) {

        await new NeuTestsVoidCommand()
            .Run(filename: "../Tests/Neu/test00.neu");

        await new NeuTestsBasicFuncCommand()
            .Run(filename: "../Tests/Neu/test01.neu");
    }
}