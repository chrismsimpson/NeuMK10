
namespace LLIR;

public static partial class LLIRTokenizerFunctions {

    ///

    private static LLIRToken Next(
        this Tokenizer<LLIRToken> tokenizer) {

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

            case 'd' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "efine", distance: 1):
                return tokenizer.NextDefine();

            case 'r' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "et", distance: 1):
                return tokenizer.NextRet();



            ///

            case var t:
                throw new Exception($"Unexpected: {t}");
        }
    }

    ///
}