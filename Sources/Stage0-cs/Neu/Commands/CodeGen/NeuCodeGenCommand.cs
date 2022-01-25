
namespace Neu;

public class NeuCodeGenCommand: ICommand {

    public NeuCodeGenCommand() { }

    ///

    public async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var generator = new NeuCodeGenerator();

            var f = new NeuFuncDecl(
                name: "foo");

            ///

            generator.Generate(f);

            ///

            var b = generator.Builder.ToString();

            ///

            WriteLine($"Generated code:\n\n```\n{b}\n```\n");

        });
    }
}