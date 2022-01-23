
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuInfixExpression ParseInfixExpression(
        this NeuParser parser,
        ISourceLocation start,
        Node lhs,
        NeuInfixOperator op,
        Node rhs) {

        switch (op) {

            case NeuAssignOperator assignOp:

                return parser.ParseAssignExpression(start, lhs, assignOp, rhs);

            ///

            case NeuBinaryOperator binaryOp:

                return parser.ParseBinaryExpression(start, lhs, binaryOp, rhs);

            ///

            default:

                throw new Exception();
        }
    }
}
