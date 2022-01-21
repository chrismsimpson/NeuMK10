
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuGenericArgClause ParseGenericArgClause(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var less = parser.Tokenizer.MaybeNextLess();

        if (less == null) {

            throw new Exception();
        }

        children.Add(less);

        ///

        var genericArgList = parser.ParseGenericArgList();

        children.Add(genericArgList);

        ///

        var greater = parser.Tokenizer.MaybeNextGreater();

        if (greater == null) {

            throw new Exception();
        }

        children.Add(greater);

        ///

        return new NeuGenericArgClause(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    ///

    public static NeuGenericArgList ParseGenericArgList(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var args = parser.ParseGenericArgs();

        ///

        return new NeuGenericArgList(
            children: args,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<NeuGenericArg> ParseGenericArgs(
        this NeuParser parser) {

        var args = new List<NeuGenericArg>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            if (parser.Tokenizer.MatchGreater()) {

                break;
            }

            ///

            var arg = parser.ParseGenericArg();

            args.Add(arg);
        }

        ///

        return args;
    }

    public static NeuGenericArg ParseGenericArg(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var typeId = parser.ParseTypeIdentifier();

        children.Add(typeId);

        ///

        if (parser.Tokenizer.MaybeNextComma() is NeuPunc comma) {

            children.Add(comma);
        }

        ///

        return new NeuGenericArg(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
