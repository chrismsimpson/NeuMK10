
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuLiteralExpression literalExpr) {
        
        switch (literalExpr) {

            case NeuBoolLiteralExpression boolLitExpr:

                return interpreter.Execute(boolLitExpr);

            ///

            case NeuNumberLiteralExpression numberLitExpr:

                return interpreter.Execute(numberLitExpr);

            ///

            default:

                throw new Exception();
        }
    }
}