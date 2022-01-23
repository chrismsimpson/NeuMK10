
namespace Neu;

public partial class NeuInfixOperator: NeuOperator {

    public NeuInfixOperator(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}

///

public static partial class NeuInfixOperatorFunctions {

    public static int GetPrecedence(
        this NeuInfixOperator infixOp) {

        switch (infixOp) {

            case NeuAssignOperator assignOp:

                return assignOp.GetPrecedence();

            ///

            case NeuBinaryOperator binaryOp:

                return binaryOp.GetPrecedence();

            ///

            default:

                throw new Exception();
        }
    }
}