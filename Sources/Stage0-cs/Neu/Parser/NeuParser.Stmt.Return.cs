
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuReturnStatement ParseReturnStatement(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var returnKeyword = parser.Tokenizer.MaybeNextReturn();

        if (returnKeyword == null) {

            throw new Exception();
        }

        children.Add(returnKeyword);

        ///

        if (!parser.Tokenizer.MatchPunc(NeuPuncType.Semicolon, NeuPuncType.RightBrace)) {

            var expr = parser.ParseExpression();

            if (expr == null) {

                throw new Exception();
            }

            children.Add(expr);
        }

        ///

        return new NeuReturnStatement(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
