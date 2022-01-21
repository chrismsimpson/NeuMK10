
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuBoolLiteralExpression boolLiteralExpr) {

        var boolKeyword = boolLiteralExpr.GetBoolKeyword();

        if (boolKeyword == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(boolKeyword);
    }
}