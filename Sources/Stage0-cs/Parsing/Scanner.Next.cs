
namespace Neu;

public static partial class IScannerFunctions {

    public static Char? MaybeNext(
        this IScanner scanner) {

        if (scanner.IsEof()) {

            return null;
        }

        ///

        return scanner.Next();
    }

    ///

    public static Char Next(
        this IScanner scanner) {

        var buffer = scanner.Peek(length: 1);

        if (buffer.Length != 1) {

            throw new Exception();
        }

        ///

        scanner.IncrementForBuffer(buffer);

        ///

        return buffer[0];
    }

    ///

    public static String Next(
        this IScanner scanner,
        int length) {

        var buffer = scanner.Peek(length: length);

        if (buffer.Length != length) {

            throw new Exception();
        }

        ///

        var maybeString = new String(buffer);

        if (IsNullOrWhiteSpace(maybeString)) {

            throw new Exception();
        }

        ///

        scanner.IncrementForBuffer(buffer);

        ///

        return maybeString;
    }

    ///

    public static Char Next(
        this IScanner scanner, 
        Char c) {

        var next = scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        return next;
    }

    ///

    public static String Next(
        this IScanner scanner, 
        String s) {

        var result = new StringBuilder();
        
        ///

        foreach (var c in s) {

            result.Append(scanner.Next(c));
        }

        ///

        return result.ToString();
    }
}
