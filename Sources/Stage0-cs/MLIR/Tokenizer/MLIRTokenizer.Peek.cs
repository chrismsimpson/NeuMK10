
namespace MLIR;

public static partial class MLIRTokenizerFunctions {

    public static MLIRToken? Peek(
        this Tokenizer<MLIRToken> tokenizer) {

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