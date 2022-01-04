
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseUnary(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuPunc p when p.PuncType == NeuPuncType.Plus:
                throw new Exception();

            ///

            default:
                return parser.ParseUpdate();
        }
    }
}
