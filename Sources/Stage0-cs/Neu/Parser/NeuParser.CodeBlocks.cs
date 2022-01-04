
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

        while (!parser.Tokenizer.IsEof()) {

            var item = parser.ParseCodeBlockItem();

            if (item == null) {

                break;
            }

            items.Add(item);
        }

        ///

        return items;
    }

    public static NeuCodeBlockItem? ParseCodeBlockItem(
        this NeuParser parser) {

        switch (parser.Tokenizer.MaybePeek()) {

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Func:
                return parser.ParseFuncDecl();

            ///

            default:
                return null;
        }
    }
}