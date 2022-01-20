
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuSimpleTypeId ParseSimpleTypeId(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var id = parser.Tokenizer.MaybeNextIdentifier();

        if (id == null) {

            throw new Exception();
        }

        children.Add(id);

        ///

        if (parser.Tokenizer.MatchLess()) {

            var genericArgClause = parser.ParseGenericArgumentClause();

            children.Add(genericArgClause);
        }

        ///

        return new NeuSimpleTypeId(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}