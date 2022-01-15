
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuExpression expr) {

        switch (expr) {

            case NeuBinaryExpression binaryExpr:

                return interpreter.Execute(binaryExpr);

            ///

            case NeuCallExpression callExpr:

                return interpreter.Execute(callExpr);

            ///

            default:
                
                throw new Exception();
        }
    }
}