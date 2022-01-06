
namespace Base;

public static partial class PathTokenizerFunctions {

    public static PathToken? MaybeNext(
        this Tokenizer<PathToken> tokenizer) {

        var next = tokenizer.Peek();

        if (next != null) {

            tokenizer.Position++;
        }

        return next;
    }

    ///

    private static PathToken Next(
        this Tokenizer<PathToken> tokenizer) {

        var nextChar = tokenizer.Scanner.Peek();

        ///

        switch (nextChar) {
            
            /// Punc

            case '/':
                return tokenizer.NextSlash();

            case '\\':
                return tokenizer.NextBackslash();

            /// Special Dir

            case '.' when tokenizer.Scanner.Match(equals: '.', distance: 1):
                return tokenizer.NextParentDirectoryComponent();

            case '.':
                return tokenizer.NextCurrentDirectoryComponent();

            ///

            case Char c when IsPathComponentPart(c):
                return tokenizer.NextComponent();

            ///

            default:
                throw new Exception();
        }
    }
}
