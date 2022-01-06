
namespace Base;

public static partial class ArgsTokenizerFunctions {

    public static bool MatchOptionToken(
        this ArgsTokenizer tokenizer) {

        if (tokenizer.Peek() is OptionName) {

            return true;
        }

        return false;
    }
}
