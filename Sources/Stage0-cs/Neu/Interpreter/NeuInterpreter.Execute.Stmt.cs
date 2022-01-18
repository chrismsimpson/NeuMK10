
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuStatement statement) {

        switch (statement) {

            case NeuExpressionStatement exprStmt:

                return interpreter.Execute(exprStmt);

            ///

            case NeuReturnStatement returnStatement:

                return interpreter.Execute(returnStatement);

            ///
           
            default:

                throw new Exception();
        }
    }
}
