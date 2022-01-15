
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuBinaryExpression binaryExpression) {

        var lhsNode = binaryExpression.GetLHSNode();

        var lhsValue = interpreter.Execute(lhsNode);

        ///

        var rhsNode = binaryExpression.GetRHSNode();

        var rhsValue = interpreter.Execute(rhsNode);

        ///

        var op = binaryExpression.GetOperator();

        ///

        switch (op.OperatorType) {
            
            case NeuBinaryOperatorType.Multiply:
                return Multiply(lhsValue, rhsValue);

            ///

            case NeuBinaryOperatorType.Divide:
                return Divide(lhsValue, rhsValue);

            ///

            case NeuBinaryOperatorType.Add:
                return Add(lhsValue, rhsValue);

            ///

            case NeuBinaryOperatorType.Subtract:
                return Subtract(lhsValue, rhsValue);

            ///

            default:
                throw new Exception();
        }
    }
}
