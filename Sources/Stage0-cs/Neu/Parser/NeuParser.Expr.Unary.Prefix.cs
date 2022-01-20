
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuPrefixExpression ParsePrefixExpression(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var op = parser.Tokenizer.MaybeNextPrefixOperator();

        if (op == null) {

            throw new Exception();
        }

        ///

        var operand = parser.ParseOperand();

        ///

        return new NeuPrefixExpression(
            children: new Node[] { op, operand },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}