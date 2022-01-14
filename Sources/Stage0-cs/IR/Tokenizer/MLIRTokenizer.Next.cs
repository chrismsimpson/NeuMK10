
namespace IR;

public static partial class IRTokenizerFunctions {

    ///

    private static IRToken Next(
        this Tokenizer<IRToken> tokenizer) {

        var peek = tokenizer.Scanner.Peek();

        ///

        switch (peek) {

            /// Punc

            case '(':
                return tokenizer.NextLeftParen();

            case ')':
                return tokenizer.NextRightParen();

            case '{':
                return tokenizer.NextLeftBrace();

            case '}':
                return tokenizer.NextRightBrace();

            case '[':
                return tokenizer.NextLeftBracket();

            case ']':
                return tokenizer.NextRightBracket();



            /// Keywords

            case 'f' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "unc", distance: 1):
                return tokenizer.NextFunc();

            case 'r' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "eturn", distance: 1):
                return tokenizer.NextReturn();



            ///

            case var t:
                throw new Exception($"Unexpected: {t}");
        }
    }

    ///
}