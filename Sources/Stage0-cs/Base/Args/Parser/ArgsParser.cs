
namespace Base;

public partial class ArgsParser {

    public ArgsTokenizer Tokenizer { get; init; }

    ///

    public ArgsParser(
        ArgsTokenizer tokenizer) {

        this.Tokenizer = tokenizer;
    }
}

///

public partial class ArgsParser {

    public static ArgsParser FromArgs(
        IEnumerable<String> args) {

        return new ArgsParser(
            ArgsTokenizer.FromArgs(args));
    }
}

///

public static partial class ArgsParserFunctions {
    
    public static IEnumerable<IArgument> ParseArguments(
        this ArgsParser parser) {

        var arguments = new List<IArgument>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            var argument = parser.ParseArgument();

            arguments.Add(argument);
        }

        ///

        return arguments;
    }

    public static IArgument ParseArgument(
        this ArgsParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case OptionName _:
                return parser.ParseOption();

            default:
                return parser.ParseSingleArgument();
        }
    }

    public static Argument ParseSingleArgument(
        this ArgsParser parser) {

        var arg = parser.Tokenizer.MaybeNextArgument();

        if (arg == null) {

            throw new Exception();
        }

        return arg;
    }

    public static Option ParseOption(
        this ArgsParser parser) {

        var opt = parser.Tokenizer.MaybeNextOptionToken();

        if (opt == null) {

            throw new Exception();
        }

        ///

        var args = parser.ParseArgTokens();

        ///

        return new Option(
            name: opt,
            args: args);
    }

    public static IEnumerable<Argument> ParseArgTokens(
        this ArgsParser parser) {

        var args = new List<Argument>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            if (parser.Tokenizer.MatchOptionToken()) {

                break;
            }

            ///

            var arg = parser.Tokenizer.MaybeNextArgument();

            if (arg == null) {
                
                break;
            }

            args.Add(arg);
        }

        ///

        return args;
    }
}
