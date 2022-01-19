
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuPatternBindingList ParsePatternBindingList(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var patternBindings = parser.ParsePatternBindings();

        ///

        return new NeuPatternBindingList(
            children: patternBindings,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<NeuPatternBinding> ParsePatternBindings(
        this NeuParser parser) {

        var patternBindings = new List<NeuPatternBinding>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            if (parser.Tokenizer.MatchSemicolonOrRightBrace()) {

                break;
            }

            ///

            var patternBinding = parser.ParsePatternBinding();

            patternBindings.Add(patternBinding);

            ///

            if (patternBinding.EndsWithNewline()) {

                break;
            }
        }

        ///

        return patternBindings;
    }

    public static NeuPatternBinding ParsePatternBinding(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var pattern = parser.ParsePattern();

        if (pattern == null) {

            throw new Exception();
        }

        children.Add(pattern);

        ///

        NeuTypeIdentifier? typeHint = null;

        ///

        if (parser.Tokenizer.MatchColon()) {

            var annotation = parser.ParseTypeAnnotation();

            children.Add(annotation);

            ///

            typeHint = annotation.GetTypeIdentifier();

            ///

            if (typeHint is NeuTypeIdentifier pushHint) {

                parser.Tokenizer.AddTypeHint(pushHint);
            }
        }

        ///

        if (parser.Tokenizer.MatchEqual()) {

            var initClause = parser.ParseInitClause();

            children.Add(initClause);
        }

        ///

        if (typeHint is NeuTypeIdentifier popHint) {

            parser.Tokenizer.RemoveTypeHint(popHint);
        }

        ///

        if (parser.Tokenizer.MatchComma()) {

            var comma = parser.Tokenizer.MaybeNextComma();

            if (comma == null) {

                throw new Exception();
            }

            children.Add(comma);
        }

        return new NeuPatternBinding(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}