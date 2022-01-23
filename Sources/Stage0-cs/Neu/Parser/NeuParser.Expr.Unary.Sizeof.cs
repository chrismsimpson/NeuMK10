
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuSizeOfExpression ParseSizeOfExpression(
        this NeuParser parser,
        ISourceLocation start,
        NeuUnaryOperator op) {

        var children = new List<Node>();

        ///

        var leftParen = parser.Tokenizer.MaybeNextLeftParen();

        if (leftParen == null) {

            throw new Exception();
        }

        children.Add(leftParen);

        ///
         
        var typeId = parser.ParseTypeIdentifier();

        children.Add(typeId);

        ///

        var rightParen = parser.Tokenizer.MaybeNextRightParen();

        if (rightParen == null) {

            throw new Exception();
        }

        children.Add(rightParen);

        ///

        return new NeuSizeOfExpression(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}