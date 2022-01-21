
namespace Neu;

public static partial class IArgumentFunctions {

    public static ICommand ToBuildCommand(
        this IEnumerable<IArgument> arguments) {

        return new NeuBuildCommand();
    }
}