
namespace Neu;

public static partial class ICommandFunctions {

    public static String GetName(
        this ICommand command) {

        switch (command)  {

            case NeuBuildCommand _:
                return "build";

            case NeuEvalCommand _:
                return "eval";

            case NeuInteractiveCommand _:
                return "interactive";

            case NeuTestsCommand _:
                return "tests";

            default:
                throw new Exception();
        }
    }
}