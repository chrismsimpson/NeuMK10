
namespace Base;

public partial class ArgsScanner {

    public IEnumerable<String> Args { get; init; }

    internal int Position { get; set; }

    ///

    public ArgsScanner(
        IEnumerable<String> args) {

        this.Args = args;

        this.Position = 0;
    }
}

///

public static partial class ArgsScannerFunctions {

    public static String Next(
        this ArgsScanner scanner) {

        var arg = scanner.Peek();

        scanner.Position++;

        return arg;
    }

    public static IEnumerable<String> NextUntil(
        this ArgsScanner scanner,
        Func<String, bool> test) {

        var result = new List<String>();

        while (!scanner.IsEof() && !test(scanner.Peek())) {

            result.Add(scanner.Next());
        }

        return result;
    }

    public static bool IsEof(
        this ArgsScanner scanner) {

        return scanner.Position == scanner.Args.Count();
    }

    public static String Peek(
        this ArgsScanner scanner) {

        return scanner.Args.ElementAt(scanner.Position);
    }
}
