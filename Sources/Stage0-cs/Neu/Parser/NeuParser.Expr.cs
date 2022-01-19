
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseExpression(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        Node? expr;

        ///

        switch (true) {

            case var _ when parser.Tokenizer.MatchPrefixOperator():
                
                expr = parser.ParsePrefixOperation();

                break;

            ///

            default:

                expr = parser.ParseTrailingExpression();

                break;
        }

        ///

        if (expr == null) {

            throw new Exception();
        }

        ///

        if (parser.Tokenizer.MatchComma()) {

            /// TODO

            throw new Exception();
        }

        ///

        return expr;
    }

    ///

    public static Node ParseTrailingExpression(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var operand = parser.ParseOperand(start);

        ///

        switch (parser.Tokenizer.MatchPostfixOperator()) {

            case true:

                return parser.ParsePostfixExpression(start, operand);

            ///

            default:

                return operand;
        }
    }
}
