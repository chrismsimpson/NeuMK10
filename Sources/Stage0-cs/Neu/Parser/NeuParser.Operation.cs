
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseOperation(
        this NeuParser parser) {

        if (parser.Tokenizer.MatchPrefixOperator()) {

            return parser.ParsePrefixOperation();
        }

        ///

        return parser.ParseUnaryInfixOrPostfixOperation();
    }

    ///

    public static Node ParseUnaryInfixOrPostfixOperation(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var operand = parser.ParseOperand(start);

        ///

        if (parser.Tokenizer.MatchInfixOrPostfixOperator()) {

            return parser.ParseInfixOrPostfixOperation(start, operand);
        }
        else {

            return operand; // unary
        }
    }

    public static Node ParseInfixOrPostfixOperation(
        this NeuParser parser,
        SourceLocation start,
        Node operand) {

        switch (parser.Tokenizer.PeekInfixOrPostfixOperator()) {

            case NeuInfixOperator infixOp:

                return parser.ParseInfixOperation();

            ///

            case NeuPostfixOperator postfixOp:

                return parser.ParsePostfixOperation();

            ///

            default:

                throw new Exception();
        }
    }
}