
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue? Execute(
        this NeuInterpreter interpreter,
        NeuReturnStatement retStmt) {

        var argument = retStmt.GetArgument();

        if (argument == null) {
            
            throw new Exception();
        }

        ///

        var value = interpreter.Execute(argument);

        ///

        return new NeuReturnValue(value);
    }
}
