
namespace IR;

public partial class IRTokenizer: Tokenizer<IRToken> {
    
    public IRTokenizer(
        IScanner scanner)
        : base(scanner) { }
}

///

public partial class IRTokenizer {

    public static IRTokenizer FromFile(
        String filename) {

        return new IRTokenizer(
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