
namespace LLIR;

public static partial class LLIRTokenizerFunctions {

    public static LLIRToken? Peek(
        this Tokenizer<LLIRToken> tokenizer) {

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