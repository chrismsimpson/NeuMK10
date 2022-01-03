
namespace Neu;

public class Tokenizer<T> where T: Token {

    internal IScanner Scanner { get; init; }

    internal IList<T> Tokens { get; init; }

    internal int Position { get; set; }

    ///

    public Tokenizer(
        IScanner scanner) {

        this.Scanner = scanner;

        this.Tokens = new List<T>();

        this.Position = 0;
    }
}

///

public static partial class TokenizerFunctions {

    public static bool IsEof<T>(
        this Tokenizer<T> tokenizer)
        where T: Token {

        if (tokenizer.GetLocation().Position == tokenizer.Scanner.GetLocation().Position) {

            return tokenizer.Scanner.IsEof();
        }

        return false;
    }

    public static SourceLocation GetLocation<T>(
        this Tokenizer<T> tokenizer)
        where T: Token {

        if (tokenizer.Position + 1 <= tokenizer.Tokens.Count) {

            return tokenizer.Tokens.ElementAt(tokenizer.Position).Start;
        }

        return tokenizer.Scanner.GetLocation();
    }

    public static T? GetPrevious<T>(
        this Tokenizer<T> tokenizer,
        int steps = 1)
        where T: Token {

        var prev = tokenizer.Position - steps;

        if (prev < 0) {

            return null;
        }

        if (tokenizer.Position <= tokenizer.Tokens.Count) {
            
            return tokenizer.Tokens.ElementAt(prev);
        }

        return null;
    }
}
