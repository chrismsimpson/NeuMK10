
namespace Neu;

public static partial class IArgumentFunctions {

    public static ICommand ToTestsCommand(
        this IEnumerable<IArgument> arguments) {

        return new NeuTestsCommand();
    }
}