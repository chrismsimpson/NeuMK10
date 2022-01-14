
namespace IR;

public static partial class IRTokenizerFunctions {

    public static IRToken? Peek(
        this Tokenizer<IRToken> tokenizer) {

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