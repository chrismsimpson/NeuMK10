
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuNumberLiteralExpression numberLiteralExpr) {

        var numberLit = numberLiteralExpr.GetNumberLiteral();

        if (numberLit == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(numberLit);
    }
}