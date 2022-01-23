
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParsePostfixExpression(
        this NeuParser parser,
        ISourceLocation start,
        Node operand) {

        var op = parser.Tokenizer.MaybeNextPostfixOperator();

        if (op == null) {

            throw new Exception();
        }

        ///

        return new NeuPostfixExpression(
            children: new Node[] { operand, op },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}