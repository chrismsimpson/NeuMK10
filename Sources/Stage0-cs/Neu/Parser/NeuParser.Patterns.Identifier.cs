
namespace Neu;

public static partial class NeuParserFunction {

    public static NeuIdentifierPattern ParseIdentifierPattern(
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

        return new NeuIdentifierPattern(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
