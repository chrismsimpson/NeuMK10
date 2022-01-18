
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuSimpleTypeId ParseSimpleTypeId(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var id = parser.Tokenizer.MaybeNextIdentifier();

        if (id == null) {

            throw new Exception();
        }

        ///

        return new NeuSimpleTypeId(
            children: new Node[] { id },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}