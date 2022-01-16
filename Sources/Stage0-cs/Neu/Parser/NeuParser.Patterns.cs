
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuPattern ParsePattern(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuIdentifier _:

                return parser.ParseIdentifierPattern();

            ///

            default:

                throw new Exception();
        }
    }
}