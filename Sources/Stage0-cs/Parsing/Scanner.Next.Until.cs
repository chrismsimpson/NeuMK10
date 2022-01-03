
namespace Neu;

public static partial class IScannerFunctions {

    public static String NextUntil(
        this IScanner scanner, 
        Char c) {

        var result = new StringBuilder();

        ///

        while (!scanner.IsEof() && c != scanner.Peek()) {

            result.Append(scanner.Next());
        }

        ///

        return result.ToString();
    }

    ///

    public static String NextUntil(
        this IScanner scanner, 
        Func<Char, bool> test) {

        var result = new StringBuilder();

        ///

        while (!scanner.IsEof() && !test(scanner.Peek())) {

            result.Append(scanner.Next());
        }

        ///

        return result.ToString();
    }

    ///

    public static String NextUntil(
        this IScanner scanner,
        String test) {

        var result = new StringBuilder();
        
        ///

        while (!scanner.IsEof() && !scanner.Match(test)) {

            result.Append(scanner.Next());
        }

        ///

        return result.ToString();
    }

    ///

    public static String NextUntilInclusive(
        this IScanner scanner,
        String test) {

        var result = new StringBuilder();

        while (!scanner.IsEof() && !scanner.Match(test)) {

            result.Append(scanner.Next());
        }

        ///

        result.Append(scanner.Next(test));

        ///

        return result.ToString();
    }

    ///

    public static String NextUntilEnd(
        this IScanner scanner) {

        var result = new StringBuilder();

        ///

        while (!scanner.IsEof()) {

            result.Append(scanner.Next());
        }

        ///

        return result.ToString();
    }
}
