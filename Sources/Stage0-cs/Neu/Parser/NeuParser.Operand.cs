
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseOperand(
        this NeuParser parser,
        SourceLocation start) {

        return parser.ParseInfixOperand(start);
    }
}