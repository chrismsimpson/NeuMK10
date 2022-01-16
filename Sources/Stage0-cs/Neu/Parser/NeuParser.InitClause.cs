
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuInitClause ParseInitClause(
        this NeuParser parser) {
            
        var start = parser.Tokenizer.GetLocation();

        /// 

        var children = new List<Node>();

        ///

        var equal = parser.Tokenizer.MaybeNextEqual();

        if (equal == null) {

            throw new Exception();
        }

        children.Add(equal);

        ///

        var expr = parser.ParseExpression();

        if (expr == null) {
            
            throw new Exception();
        }

        children.Add(expr);

        ///

        return new NeuInitClause(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
