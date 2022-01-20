
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuExpression expr) {

        switch (expr) {

            case NeuPrefixExpression prefixExpr:

                return interpreter.Execute(prefixExpr);

            ///

            case NeuInfixExpression infixExpr:

                return interpreter.Execute(infixExpr);

            ///

            case NeuCallExpression callExpr:

                return interpreter.Execute(callExpr);

            ///

            case NeuNumberLiteralExpression numberLitExpr:

                return interpreter.Execute(numberLitExpr);

            ///

            case NeuBoolLiteralExpression boolLitExpr:

                return interpreter.Execute(boolLitExpr);

            ///

            case NeuIdentifierExpression idExpr:

                return interpreter.Execute(idExpr);

            ///

            case NeuPostfixExpression postfixExpr:

                return interpreter.Execute(postfixExpr);

            ///

            default:
                
                throw new Exception();
        }
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuInfixExpression infixExpr) {

        var lhsNode = infixExpr.GetLHSNode();

        var lhsResult = interpreter.Execute(lhsNode);

        ///

        var rhsNode = infixExpr.GetRHSNode();

        var rhsResult = interpreter.Execute(rhsNode);

        ///

        var op = infixExpr.GetOperator();

        ///

        return interpreter.Execute(op, lhsResult, rhsResult);
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuInfixOperator op,
        NeuOperation lhsResult,
        NeuOperation rhsResult) {

        switch (op) {

            case NeuAssignOperator assignOp:

                throw new Exception();

            ///

            case NeuBinaryOperator binaryOp:

                return interpreter.Execute(binaryOp, lhsResult, rhsResult);

            ///

            default:

                throw new Exception();
        }
    }
}