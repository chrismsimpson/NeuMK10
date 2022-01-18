
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseExponentiation(
        this NeuParser parser) {
            
        return parser.ParseUnary();
    }
}
