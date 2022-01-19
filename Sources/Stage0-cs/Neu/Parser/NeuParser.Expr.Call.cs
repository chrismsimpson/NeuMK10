
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuCallExpression ParseCallExpression(
        this NeuParser parser,
        SourceLocation start,
        Node first,
        IEnumerable<Node> arguments) {

        var children = new List<Node>();

        ///

        children.Add(first);
        
        ///

        children.AddRange(arguments);

        ///

        if (parser.Tokenizer.MatchSemicolon()) {

            var semicolon = parser.Tokenizer.MaybeNextSemicolon();

            if (semicolon == null) {

                throw new Exception();
            }

            children.Add(semicolon);
        }

        ///

        return new NeuCallExpression(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<Node> ParseCallArguments(
        this NeuParser parser) {

        var nodes = new List<Node>();

        ///

        var leftParen = parser.Tokenizer.MaybeNextLeftParen();

        if (leftParen == null) {

            throw new Exception();
        }

        nodes.Add(leftParen);

        ///

        if (!parser.Tokenizer.MatchRightParen()) {

            while (!parser.Tokenizer.IsEof()) {

                switch (parser.Tokenizer.Peek()) {

                    ///

                    default:

                        nodes.Add(parser.ParseExpression());

                        break;
                }

                ///

                if (parser.Tokenizer.MatchRightParen()) {

                    break;
                }

                ///
                    
                    // TODO: ExpectCommaSeparator?
            }
        }

        ///

        var rightParen = parser.Tokenizer.MaybeNextRightParen();

        if (rightParen == null) {

            throw new Exception();
        }

        nodes.Add(rightParen);

        ///

        return nodes;
    }
}
