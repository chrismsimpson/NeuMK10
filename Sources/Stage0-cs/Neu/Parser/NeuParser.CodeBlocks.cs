
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

            if (parser.Tokenizer.MatchPunc(NeuPuncType.RightBrace)) {

                break;
            }

            ///

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

        switch (parser.Tokenizer.Peek()) {

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Func:
            
                return parser.ParseFuncDecl();

            /// Comments

            case NeuComment _:

                return parser.ParseStatementAfterDroppingComments();

            ///

            default:

                return parser.ParseStatement();

            // ///

            // case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Return:
            //     return parser.ParseReturnStatement();

            // ///

            // default:
            //     return null;
        }
    }

    public static NeuCodeBlock ParseCodeBlock(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var leftBrace = parser.Tokenizer.MaybeNextLeftBrace();

        if (leftBrace == null) {

            throw new Exception();
        }

        children.Add(leftBrace);

        ///

        var list = parser.ParseCodeBlockItemList();

        children.Add(list);

        ///

        var rightBrace = parser.Tokenizer.MaybeNextRightBrace();

        if (rightBrace == null) {

            throw new Exception();
        }

        children.Add(rightBrace);

        ///

        return new NeuCodeBlock(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}