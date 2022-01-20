
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuPostfixExpression postfixExpr) {

        var operand = postfixExpr.GetOperand() as NeuExpression;

        if (operand == null) {

            throw new Exception();
        }

        ///

        var op = postfixExpr.GetOperator();

        if (op == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(operand, op);
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuExpression operand,
        NeuPostfixOperator op) {

        switch (op.OperatorType) {

            case NeuUnaryOperatorType.Increment:

                return interpreter.PostfixIncrement(operand);

            ///

            case NeuUnaryOperatorType.Decrement:

                return interpreter.PostfixDecrement(operand);

            ///

            default:

                throw new Exception();
        }
    }
}