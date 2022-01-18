
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuIdentifier? MaybeNextIdentifier(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Peek() is NeuIdentifier i) {

            tokenizer.Position++;
            
            return i;
        }

        ///

        return null;
    }

    ///

    private static NeuIdentifier NextIdentifier(
        this Tokenizer<NeuToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.NextWhile(c => IsNeuIdentifierPart(c));

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuIdentifier(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }
}
