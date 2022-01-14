
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParsePrimary(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuIdentifier _:

                // TODO: Optimize w ++

                var id = parser.Tokenizer.MaybeNextIdentifier();

                if (id == null) {

                    throw new Exception();
                }

                return id;

            ///

            case NeuNumberLiteral _:

                // TODO: Optimize w ++
                
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
