
namespace Neu;

public static partial class NeuParserFunctions {

    public static void DropComments(
        this NeuParser parser) {

        while (!parser.Tokenizer.IsEof()) {

            switch (parser.Tokenizer.Peek()) {

                case NeuComment _:

                    // TODO: Optimization opportunity w `parser.Tokenizer.Position++;`

                    parser.Tokenizer.MaybeNextComment();

                    break;

                ///

                default:

                    return;
            }
        }
    }
}
