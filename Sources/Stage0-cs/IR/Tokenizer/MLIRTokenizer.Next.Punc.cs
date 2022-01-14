
namespace IR;

public static partial class IRTokenizerFunctions {

    public static IRPunc? MaybeNextPunc(
        this Tokenizer<IRToken> tokenizer,
        IRPuncType puncType) {

        if (tokenizer.Peek() is IRPunc p && p.PuncType == puncType) {

            tokenizer.Position++;

            return p;
        }

        ///

        return null;
    }

    public static IRPunc? MaybeNextLeftParen(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(IRPuncType.LeftParen);
    }

    public static IRPunc? MaybeNextRightParen(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(IRPuncType.RightParen);
    }

    public static IRPunc? MaybeNextLeftBrace(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(IRPuncType.LeftBrace);
    }

    public static IRPunc? MaybeNextRightBrace(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(IRPuncType.RightBrace);
    }

    ///

    private static IRPunc NextPunc(
        this Tokenizer<IRToken> tokenizer,
        Char c,
        IRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new IRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    private static IRPunc NextPunc(
        this Tokenizer<IRToken> tokenizer,
        String s,
        IRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new IRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    ///

    private static IRPunc NextLeftParen(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc('(', IRPuncType.LeftParen);
    }

    private static IRPunc NextRightParen(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc(')', IRPuncType.RightParen);
    }

    private static IRPunc NextLeftBrace(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc('{', IRPuncType.LeftBrace);
    }

    private static IRPunc NextRightBrace(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc('}', IRPuncType.RightBrace);
    }

    private static IRPunc NextLeftBracket(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc('[', IRPuncType.LeftBracket);
    }

    private static IRPunc NextRightBracket(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextPunc(']', IRPuncType.RightBracket);
    }
}