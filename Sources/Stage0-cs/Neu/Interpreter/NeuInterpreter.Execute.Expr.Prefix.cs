
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuPrefixExpression prefixExpr) {

        var op = prefixExpr.GetOperator();

        if (op == null) {

            throw new Exception();
        }

        ///

        var operand = prefixExpr.GetOperand() as NeuExpression;

        if (operand == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(op, operand);
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuPrefixOperator op,
        NeuExpression operand) {
        
        switch (op.OperatorType) {

            case NeuUnaryOperatorType.Increment:

                return interpreter.PrefixIncrement(operand);

            ///

            case NeuUnaryOperatorType.Decrement:

                return interpreter.PrefixDecrement(operand);

            ///

            default:

                throw new Exception();
        }
    }
}