
namespace MLIR;

public partial class MLIRTokenizer: Tokenizer<MLIRToken> {
    
    public MLIRTokenizer(
        IScanner scanner)
        : base(scanner) { }
}

///

public partial class MLIRTokenizer {

    public static MLIRTokenizer FromFile(
        String filename) {

        return new MLIRTokenizer(
            new StreamScanner(
                new FileStream(
                    path: filename,
                    mode: FileMode.Open,
                    access: FileAccess.Read,
                    share: FileShare.Read,
                    bufferSize: 4096,
                    useAsync: true)));
    }
}