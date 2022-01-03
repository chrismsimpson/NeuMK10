
namespace Neu;

public static partial class NeuParserFunctions {
    
    public static NeuCodeBlockItemList ParseCodeBlockItemList(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var items = parser.ParseCodeBlockItems();

        ///

        return new NeuCodeBlockItemList(
            children: items,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<NeuCodeBlockItem> ParseCodeBlockItems(
        this NeuParser parser) {

        var items = new List<NeuCodeBlockItem>();

        ///

        // TODO:

        ///

        return items;
    }
}