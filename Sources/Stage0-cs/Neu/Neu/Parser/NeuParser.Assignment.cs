
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseAssignment(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        return parser.ParseAssignment(start, null);
    }

    public static Node ParseAssignment(
        this NeuParser parser,
        SourceLocation start,
        NeuPunc? leadingPunc) {

        switch (parser.Tokenizer.Peek()) {

            case NeuToken t:

                var conditional = parser.ParseConditional(start, leadingPunc);

                if (parser.Tokenizer.MatchAssignmentOperator()) {
                    
                    return parser.ParseAssignmentExpression(start, conditional);
                }
                else {

                    return conditional;
                }

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuExpression ParseAssignmentExpression(
        this NeuParser parser,
        SourceLocation start,
        Node id) {

        throw new Exception();
    }
}
