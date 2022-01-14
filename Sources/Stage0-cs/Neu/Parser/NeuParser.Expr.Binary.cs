
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuBinaryExpression ParseBinaryExpression(
        this NeuParser parser,
        SourceLocation start,
        NeuPunc? leadingPunc,
        Node lhs,
        NeuBinaryOperator op,
        Node rhs) {

        var children = new List<Node>();

        ///

        if (leadingPunc is NeuPunc p1) {

            children.Add(p1);
        }

        ///

        children.Add(lhs);

        ///


        children.Add(op);

        ///

        children.Add(rhs);

        ///

        switch (leadingPunc) {

            case NeuPunc lhsPunc when lhsPunc.PuncType == NeuPuncType.LeftParen:

                var rightParen = parser.Tokenizer.MaybeNextRightParen();

                if (rightParen == null) {

                    throw new Exception();
                }

                children.Add(rightParen);

                break;

            ///

            case null:

                break;

            ///

            default:

                throw new Exception();
        }

        ///

        if (parser.Tokenizer.MatchSemicolon()) {

            var semicolon = parser.Tokenizer.MaybeNextSemicolon();

            if (semicolon == null) {

                throw new Exception();
            }

            children.Add(semicolon);
        }

        ///

        var startAlt = start;

        if (leadingPunc == null) {
            
            startAlt = lhs.Start;
        }
        
        ///

        return new NeuBinaryExpression(
            children: children,
            start: startAlt,
            end: parser.Tokenizer.GetLocation());
    }
}
