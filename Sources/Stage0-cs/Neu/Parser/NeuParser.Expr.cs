
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseExpression(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var operation = parser.ParseOperation();

        ///

        if (parser.Tokenizer.MatchComma()) {

            /// TODO

            throw new Exception();
        }

        ///

        return operation;
    }
}
