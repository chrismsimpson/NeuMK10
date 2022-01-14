
namespace Neu;

public partial class NeuTokenizer {

    public static bool IsNumberLiteralStart(
        Char c) {

        return c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.';
    }

    public static bool IsNumberLiteralPart(
        Char c) {
            
        return c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.';
    }
}

///

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

        switch (true) {

            case var _ when !source.Contains('.'):

                int intValue = 0;

                if (!int.TryParse(source, out intValue)) {
                    
                    throw new Exception();
                }

                ///

                return new NeuIntegerLiteral(
                    source: source,
                    start: start,
                    end: tokenizer.GetLocation(),
                    value: intValue);

                    ///

            default:

                float floatValue = 0;

                if (!float.TryParse(source, out floatValue)) {

                    throw new Exception();
                }

                ///

                return new NeuFloatLiteral(
                    source: source,
                    start: start,
                    end: tokenizer.GetLocation(),
                    value: floatValue);
        }
    }
}
