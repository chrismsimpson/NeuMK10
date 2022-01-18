
namespace Neu;

public partial class NeuTokenizer: Tokenizer<NeuToken> {

    public Stack<NeuTypeIdentifier> TypeHints { get; init; }

    ///

    public NeuTokenizer(
        IScanner scanner)
        : base(scanner) {
        
        this.TypeHints = new Stack<NeuTypeIdentifier>();
    }
}

///

public partial class NeuTokenizer {

    public static NeuTokenizer FromFile(
        String filename) {

        return new NeuTokenizer(
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

///

public static partial class NeuParserFunctions {

    public static NeuTypeIdentifier? GetTypeHint(
        this Tokenizer<NeuToken> tokenizer) {

        var t = tokenizer as NeuTokenizer;

        if (t == null) {

            throw new Exception($"Unsupported tokenizer");
        }

        ///

        return t.TypeHints.FirstOrDefault();
    }

    public static void AddTypeHint(
        this Tokenizer<NeuToken> tokenizer,
        NeuTypeIdentifier typeIdentifier) {

        var t = tokenizer as NeuTokenizer;

        if (t == null) {

            throw new Exception($"Unsupported tokenizer");
        }

        ///

        t.TypeHints.Push(typeIdentifier);
    }

    public static void RemoveTypeHint(
        this Tokenizer<NeuToken> tokenizer,
        NeuTypeIdentifier typeIdentifier) {

        var t = tokenizer as NeuTokenizer;

        if (t == null) {

            throw new Exception($"Unsupported tokenizer");
        }

        ///

        var first = t.TypeHints.FirstOrDefault();

        ///

        if (first == null) {

            throw new Exception();
        }

        ///

        if (!Equals(first, typeIdentifier)) {

            throw new Exception();
        }

        ///

        t.TypeHints.Pop();
    }
}