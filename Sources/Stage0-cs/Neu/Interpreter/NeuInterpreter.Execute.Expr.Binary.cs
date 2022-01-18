
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuBinaryOperator op,
        NeuOperation lhsResult,
        NeuOperation rhsResult) {

        switch (op.OperatorType) {

            case NeuBinaryOperatorType.Multiply:
                return interpreter.Multiply(lhsResult, rhsResult);

            ///

            case NeuBinaryOperatorType.Divide:
                return interpreter.Divide(lhsResult, rhsResult);

            ///

            case NeuBinaryOperatorType.Add:
                return interpreter.Add(lhsResult, rhsResult);

            ///

            case NeuBinaryOperatorType.Subtract:
                return interpreter.Subtract(lhsResult, rhsResult);

            ///

            default:
                throw new Exception();
        }
    }
}
