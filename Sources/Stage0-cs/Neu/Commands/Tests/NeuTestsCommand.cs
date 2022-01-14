
namespace Neu;

public class NeuTestsCommand: ICommand {

    public NeuTestsCommand() { }

    ///

    public async Task Run(
        String filename,
        IEnumerable<IArgument> arguments) {

        var args = new List<String>();

        args.Add("neu");

        args.Add(filename);

        var n = arguments.ToArgs();

        args.AddRange(n);

        var a = args.ToArguments();

        await this.Run(a);
    }

    public async Task Run(
        params String[] args) {

        await this.Run(args.ToArguments());
    }

    public virtual async Task Run(
        IEnumerable<IArgument> arguments) {

        var args = arguments.DropArguments(number: 1);

        await new NeuTestsVoidCommand()
            .Run(filename: "../Tests/Neu/test00.neu", args);

        await new NeuTestsBasicIntFuncCommand()
            .Run(filename: "../Tests/Neu/test01.neu", args);

        await new NeuTestsBasicFloatFuncCommand()
            .Run(filename: "../Tests/Neu/test02.neu", args);
    }
}