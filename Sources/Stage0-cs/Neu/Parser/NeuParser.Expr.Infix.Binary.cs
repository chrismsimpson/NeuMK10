
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuBinaryExpression ParseBinaryExpression(
        this NeuParser parser,
        ISourceLocation start,
        Node lhs,
        NeuBinaryOperator op,
        Node rhs) {

        return new NeuBinaryExpression(
            children: new Node[] { lhs, op, rhs },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
