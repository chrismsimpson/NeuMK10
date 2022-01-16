
namespace Neu;

public static partial class NeuParserFunctions {

    // USE: ParseTypeIdentifier
    // public static NeuNode ParseType(
    //     this NeuParser parser) {

    //     if (parser.Tokenizer.MatchLeftParen()) {

    //         // TODO: handle closures here?

    //         return parser.ParseTupleType();
    //     }

    //     ///

    //     return parser.ParseSimpleTypeId();
    // }

    public static NeuNode ParseTupleType(
        this NeuParser parser) {

        // TODO: return NeuTupleType

        throw new Exception();
    }

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