
namespace Neu;

public static partial class JSParserFunctions {

    public static Node ParsePrimary(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuNumberLiteral _:
                
                var number = parser.Tokenizer.MaybeNextNumberLiteral();

                if (number == null) {

                    throw new Exception();
                }

                return number;

            ///

            case var t:

                throw new Exception($"Unexpected: {t}");
        }
    }
}
