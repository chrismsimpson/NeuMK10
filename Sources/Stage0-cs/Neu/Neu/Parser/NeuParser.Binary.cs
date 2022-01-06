
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseBinary(
        this NeuParser parser,
        SourceLocation start,
        NeuPunc? leadingPunc) {

        var expr = parser.ParseExponentiation();

        ///

        switch (parser.Tokenizer.Peek()) {

            case NeuPunc p when p.PuncType == NeuPuncType.RightBrace || p.PuncType == NeuPuncType.Semicolon:
                return expr;

            ///

            default:
                break;
        }

        ///

        throw new Exception();
    }
}
