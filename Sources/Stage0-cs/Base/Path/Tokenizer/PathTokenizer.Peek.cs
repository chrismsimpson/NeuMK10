
namespace Base;

public static partial class PathTokenizerFunctions {

    public static PathToken? Peek(
        this Tokenizer<PathToken> tokenizer) {

        if (tokenizer.Position + 1 <= tokenizer.Tokens.Count) {

            return tokenizer.Tokens.ElementAt(tokenizer.Position);
        }

        ///

        if (tokenizer.Scanner.IsEof()) {
            
            return null;
        }

        ///

        var next = tokenizer.Next();

        tokenizer.Tokens.Add(next);

        return next;
    }
}
