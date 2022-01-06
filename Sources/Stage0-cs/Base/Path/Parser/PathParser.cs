
namespace Base;

public partial class PathParser : Parser<PathToken> {

    public PathParser(
        PathTokenizer tokenizer)
        : base(tokenizer) { }
}

///

public partial class PathParser {

    public static PathParser FromString(
        String source) {

        return new PathParser(
            PathTokenizer.FromString(source));
    }
}

///

public static partial class PathParserFunctions {

    public static Path ParsePath(
        this PathParser parser) {

        var tokens = parser.ParseTokens();

        ///

        return new Path(tokens);
    }

    public static IEnumerable<PathToken> ParseTokens(
        this PathParser parser) {

        var tokens = new List<PathToken>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            var token = parser.Tokenizer.MaybeNext();

            if (token == null) {
                
                break;
            }

            tokens.Add(token);
        }

        ///

        return tokens;
    }
}
