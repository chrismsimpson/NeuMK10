
namespace Neu;

public static partial class IArgumentFunctions {

    public static ICommand ToCommand(
        this IEnumerable<IArgument> arguments) {

        switch (arguments.GetFirstArgumentSource()) {

            /// Build

            case "build":
                return arguments.ToBuildCommand();



            /// Tests

            case "tests":
                return arguments.ToTestsCommand();



            /// Eval

            case String source when source.ToAbsolutePathString() is String:
                return arguments.ToEvalCommand();



            /// Interactive

            case var _ when arguments.Count() == 1:
                return arguments.ToInteractiveCommand();




            ///

            default:
                throw new Exception();
        }
    }
}