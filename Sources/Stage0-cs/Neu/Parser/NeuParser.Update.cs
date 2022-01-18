
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseUpdate(
        this NeuParser parser) {

        return parser.ParseLeftHandSideAllowCall();
    }

    public static Node ParseLeftHandSideAllowCall(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        Node expr;

        ///

        switch (parser.Tokenizer.Peek()) {

            ///

            default:

                expr = parser.ParsePrimary();

                break;
        }

        ///

        var done = false;

        while (!parser.Tokenizer.IsEof() && !done) {

            switch (parser.Tokenizer.Peek()) {

                case NeuPunc p when p.PuncType == NeuPuncType.LeftParen:

                    var arguments = parser.ParseCallArguments();

                    expr = parser.ParseCallExpression(start, expr, arguments);

                    break;

                ///

                default:

                    done = true;

                    break;
            }
        }

        ///

        return expr;
    }
}
