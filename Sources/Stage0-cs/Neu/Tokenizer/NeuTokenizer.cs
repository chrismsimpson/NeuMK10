
namespace Neu;

public partial class NeuTokenizer: Tokenizer<NeuToken> {

    public NeuTokenizer(
        IScanner scanner)
        : base(scanner) { }
}

///

public partial class NeuTokenizer {

    public static NeuTokenizer FromFile(
        String filename) {

        return new NeuTokenizer(
            new StreamScanner(
                NewFileStream(filename, readOnly: false)));
    }
}