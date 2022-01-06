
namespace LLIR;

public partial class LLIRTokenizer: Tokenizer<LLIRToken> {
    
    public LLIRTokenizer(
        IScanner scanner)
        : base(scanner) { }
}

///

public partial class LLIRTokenizer {
    
    public static LLIRTokenizer FromFile(
        String filename) {

        return new LLIRTokenizer(
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