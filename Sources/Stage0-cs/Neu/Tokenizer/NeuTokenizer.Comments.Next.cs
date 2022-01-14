
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuComment? MaybeNextComment(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Peek() is NeuComment c) {

            tokenizer.Position++;

            ///

            return c;
        }

        ///

        return null;
    }

    ///

    private static NeuComment NextLineEndComment(
        this Tokenizer<NeuToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.NextUntil(c => c == '\n');

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuComment(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }

    ///

    private static NeuComment NextInlineComment(
        this Tokenizer<NeuToken> tokenizer) {
            
        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.NextUntilInclusive("*/");

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuComment(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }
}