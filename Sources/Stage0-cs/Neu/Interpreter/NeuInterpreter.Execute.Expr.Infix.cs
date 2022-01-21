
namespace Neu;

public static partial class NeuInterpreterFunctions {

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