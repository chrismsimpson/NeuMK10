
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuVarDecl ParseVarDecl(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var varKeyword = parser.Tokenizer.MaybeNextLetOrVar();

        if (varKeyword == null) {

            throw new Exception();
        }

        children.Add(varKeyword);

        ///

        var patternBindingList = parser.ParsePatternBindingList();

        children.Add(patternBindingList);

        ///

        return new NeuVarDecl(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}