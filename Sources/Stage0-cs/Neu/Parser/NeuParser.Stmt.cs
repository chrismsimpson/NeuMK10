
namespace Neu;

public static partial class NeuParserFunctions {
    
    public static NeuStatement ParseStatementAfterDroppingComments(
        this NeuParser parser) {

        parser.DropComments();

        ///
                
        return parser.ParseStatement();
    }

    ///

    public static NeuStatement ParseStatement(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuIdentifier _:

                return parser.ParseLabeledStatement();

            ///

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Return:

                return parser.ParseReturnStatement();

            ///

            case var p:

                throw new Exception($"Unsupported: {p}"); 
        }
    }

    ///

    public static NeuStatement ParseLabeledStatement(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var node = parser.ParseExpression();

        ///
        
        return parser.ParseExpressionStatement(start, node);
    }

    ///

    public static NeuExpressionStatement ParseExpressionStatement(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var expr = parser.ParseExpression();

        ///

        return parser.ParseExpressionStatement(start, expr);
    }

    ///

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