
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuExpressionStatement ParseExpressionStatement(
        this NeuParser parser,
        SourceLocation start,
        Node node) {

        var children = new List<Node>();

        ///

        children.Add(node);

        ///

        if (parser.Tokenizer.MatchSemicolon()) {
            
            var semicolon = parser.Tokenizer.MaybeNextSemicolon();

            if (semicolon == null) {

                throw new Exception();
            }

            children.Add(semicolon);
        }

        ///

        return new NeuExpressionStatement(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
