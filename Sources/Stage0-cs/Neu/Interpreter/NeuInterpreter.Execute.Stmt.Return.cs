
namespace Neu;

public static partial class JSInterpreterFunctions {

    public static NeuValue? Execute(
        this NeuInterpreter interpreter,
        NeuReturnStatement retStmt) {

        var argument = retStmt.GetArgument();

        if (argument == null) {
            
            throw new Exception();
        }

        ///

        var value = interpreter.Execute(argument);

        // interpreter.DoReturn();

        // return value;

        return new NeuReturnValue(value);
    }

    // public static void DoReturn(
    //     this NeuInterpreter interpreter) {

    //     // TODO: Actually return execution from within a method
    // }
}
