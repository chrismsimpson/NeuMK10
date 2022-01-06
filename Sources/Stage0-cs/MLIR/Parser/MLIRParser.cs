
namespace MLIR;

public partial class MLIRParser: Parser<MLIRToken> {

    public MLIRParser(
        MLIRTokenizer tokenizer)
        : base(tokenizer) { }
}

///

public partial class MLIRParser {

    public static MLIRParser FromFile(
        String filename) {

        return new MLIRParser(
            MLIRTokenizer.FromFile(filename));
    }
}