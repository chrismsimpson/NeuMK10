
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue? Execute(
        this NeuInterpreter interpreter,
        NeuStatement statement) {

        switch (statement) {

            case NeuReturnStatement returnStatement:
                return interpreter.Execute(returnStatement);

            ///
           
            default:
                throw new Exception();
        }
    }
}
