
namespace Neu;

public static partial class IArgumentFunctions {

    public static ICommand ToCodeGenCommand(
        this IEnumerable<IArgument> arguments) {

        return new NeuCodeGenCommand();
    }
}