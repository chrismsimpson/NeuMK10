
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuNumberLiteral? MaybeNextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Peek() is NeuNumberLiteral n) {

            tokenizer.Position++;

            return n;
        }

        ///

        return null;
    }

    ///

    private static NeuNumberLiteral NextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.NextWhile(c => IsNumberLiteralPart(c));

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return tokenizer.NextNumberLiteral(start, next);
    }

    private static NeuNumberLiteral NextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer,
        SourceLocation start,
        String source) {

        String? rawHint = null;

        ///

        if (tokenizer.GetTypeHint() is NeuTypeIdentifier typeId) {

            switch (typeId) {

                case NeuSimpleTypeId simpleTypeId when simpleTypeId.GetIdentifer() is NeuIdentifier id:

                    rawHint = id.Source;

                    break;

                ///

                default:

                    break;
            }
        }

        ///

        if (IsNullOrWhiteSpace(rawHint)) {

            rawHint = source.Contains('.')
                ? "Float"
                : "Int";
        }

        ///

        switch (rawHint) {

            case "Int":

                int intValue = 0;

                if (!int.TryParse(source, out intValue)) {
                    
                    throw new Exception();
                }

                ///

                var e = tokenizer.Scanner.GetLocation();

                return new NeuIntegerLiteral(
                    source: source,
                    start: start,
                    end: e,
                    value: intValue);

            ///

            case "Float":

                float floatValue = 0;

                if (!float.TryParse(source, out floatValue)) {

                    throw new Exception();
                }

                ///

                return new NeuFloatLiteral(
                    source: source,
                    start: start,
                    end: tokenizer.Scanner.GetLocation(),
                    value: floatValue);

            ///

            default:

                throw new Exception();
        }
    }
}
