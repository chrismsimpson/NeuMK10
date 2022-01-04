
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseConditional(
        this NeuParser parser,
        SourceLocation start,
        NeuPunc? leadingPunc) {

        return parser.ParseBinary(start, leadingPunc);
    }
}
