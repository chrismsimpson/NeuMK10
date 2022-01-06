
namespace Base;

public static partial class PathTokenizerFunctions {

    private static PathPunc NextPunc(
        this Tokenizer<PathToken> tokenizer,
        Char c,
        PathPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        return new PathPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    private static PathPunc NextPunc(
        this Tokenizer<PathToken> tokenizer,
        String s,
        PathPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(length: s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        return new PathPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    ///

    private static PathPunc NextSlash(
        this Tokenizer<PathToken> tokenizer) {

        return tokenizer.NextPunc('/', PathPuncType.Slash);
    }

    private static PathPunc NextBackslash(
        this Tokenizer<PathToken> tokenizer) {
            
        return tokenizer.NextPunc('\\', PathPuncType.Backslash);
    }
}
