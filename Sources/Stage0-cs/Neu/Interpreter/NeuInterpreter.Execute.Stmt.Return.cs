
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuReturnStatement retStmt) {

        var argument = retStmt.GetArgument();

        if (argument == null) {
            
            throw new Exception();
        }

        ///

        var result = interpreter.Execute(argument);

        ///

        return new NeuReturnResult(result);
    }
}
