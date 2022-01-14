
namespace IR;

public partial class IRParser: Parser<IRToken> {

    public IRParser(
        IRTokenizer tokenizer)
        : base(tokenizer) { }
}

///

public partial class IRParser {

    public static IRParser FromFile(
        String filename) {

        return new IRParser(
            IRTokenizer.FromFile(filename));
    }
}