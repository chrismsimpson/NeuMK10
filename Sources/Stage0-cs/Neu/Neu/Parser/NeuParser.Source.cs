
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuSource ParseSource(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var list = parser.ParseCodeBlockItemList();

        children.Add(list);

        ///

        return new NeuSource(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}