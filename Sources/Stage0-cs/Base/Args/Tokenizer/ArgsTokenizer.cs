
namespace Base;
    
public partial class ArgsTokenizer {

    internal ArgsScanner Scanner { get; init; }

    internal IList<Argument> Tokens { get; init; }

    internal int Position { get; set; }

    ///

    public ArgsTokenizer(
        ArgsScanner scanner) {

        this.Scanner = scanner;

        this.Tokens = new List<Argument>();

        this.Position = 0;
    } 
}

///

public partial class ArgsTokenizer {

    public static ArgsTokenizer FromArgs(
        IEnumerable<String> args) {

        return new ArgsTokenizer(
            new ArgsScanner(args));
    }
}

///

public static partial class ArgsTokenizerFunctions {

    public static bool IsEof(
        this ArgsTokenizer tokenizer) {

        if (tokenizer.GetLocation() == tokenizer.Scanner.Position) {
            
            return tokenizer.Scanner.IsEof();
        }

        return false;
    }

    ///

    public static int GetLocation(
        this ArgsTokenizer tokenizer) {

        if (tokenizer.Position + 1 <= tokenizer.Tokens.Count) {

            return tokenizer.Tokens.ElementAt(tokenizer.Position).Position;
        }

        return tokenizer.Scanner.Position;
    }

    ///

    public static Argument? MaybeNext(
        this ArgsTokenizer tokenizer) {

        var next = tokenizer.Peek();

        if (next != null) {

            tokenizer.Position++;
        }

        return next;
    }

    private static Argument Next(
        this ArgsTokenizer tokenizer) {

        switch (tokenizer.Scanner.Peek()) {

            case String next when next.StartsWith("--"):
                return tokenizer.NextOptionToken();

            case String next when next.StartsWith("/") || next.EndsWith(".dll") || next == "./":
                return tokenizer.NextUnknownArgument();

            case String _:
                return tokenizer.NextArgument();

            default:
                throw new Exception();
        }
    }

    private static OptionName NextOptionToken(
        this ArgsTokenizer tokenizer) {

        var position = tokenizer.Scanner.Position;

        ///

        return new OptionName(
            source: tokenizer.Scanner.Next(),
            position: position);
    }

    private static UnknownArgument NextUnknownArgument(
        this ArgsTokenizer tokenizer) {

        var position = tokenizer.Scanner.Position;

        ///

        return new UnknownArgument(
            source: tokenizer.Scanner.Next(),
            position: position);
    }

    private static Argument NextArgument(
        this ArgsTokenizer tokenizer) {

        var position = tokenizer.Scanner.Position;

        ///

        return new Argument(
            source: tokenizer.Scanner.Next(),
            position: position);
    }

    ///

    public static OptionName? MaybeNextOptionToken(
        this ArgsTokenizer tokenizer) {

        var next = tokenizer.MaybeNext();

        ///

        if (next is OptionName t) {

            return t;
        }

        ///

        return null;
    }

    public static UnknownArgument? MaybeNextUnknownArgument(
        this ArgsTokenizer tokenizer) {

        var next = tokenizer.MaybeNext();

        ///

        if (next is UnknownArgument t) {

            return t;
        }

        ///

        return null;
    }

    public static Argument? MaybeNextArgument(
        this ArgsTokenizer tokenizer) {

        var next = tokenizer.MaybeNext();

        ///

        if (next is Argument t) {

            return t;
        }

        ///

        return null;
    }
}