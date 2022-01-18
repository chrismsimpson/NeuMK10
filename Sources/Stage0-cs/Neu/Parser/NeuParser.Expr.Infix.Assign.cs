
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuAssignmentExpression ParseAssignExpression(
        this NeuParser parser,
        SourceLocation start,
        Node lhs,
        NeuAssignOperator op,
        Node rhs) {

        return new NeuAssignmentExpression(
            children: new Node[] { lhs, op, rhs },
            start: start,
            end: parser.Tokenizer.GetLocation());         
    }
}
