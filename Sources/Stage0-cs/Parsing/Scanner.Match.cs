
namespace Neu;

public static partial class IScannerFunctions {

    public static bool Match(
        this IScanner scanner,
        Char equals,
        int distance = 0) {

        if (scanner.IsEof()) {

            return false;
        }

        ///

        var len = 1 + distance;

        ///

        var end = scanner.Position + len;

        if (end > scanner.GetLength()) {

            return false;
        }

        ///

        var buffer = scanner.Peek(len);

        if (buffer.Length != len) {

            throw new Exception();
        }

        ///

        var next = buffer[distance];

        ///

        return next == equals;
    }

    public static bool Match(
        this IScanner scanner,
        String equals,
        int distance = 0) {

        if (scanner.IsEof()) {

            return false;
        }

        ///

        var len = equals.Length + distance;

        ///

        var end = scanner.Position + len;

        if (end > scanner.GetLength()) {

            return false;
        }

        ///

        var buffer = scanner.Peek(len);

        if (buffer.Length != len) {

            throw new Exception();
        }

        ///

        var next = new String(buffer.Skip(distance).ToArray());

        ///

        return next == equals;
    }

    ///

    public static bool MatchWithTrailingWhitespace(
        this IScanner scanner,
        String equals,
        int distance = 0) {

        if (scanner.IsEof()) {

            return false;
        }

        ///

        var len = equals.Length + distance + 1;

        var end = scanner.Position + len;

        if (end > scanner.GetLength()) {

            return false;
        }

        ///

        var buffer = scanner.Peek(len);

        if (buffer.Length != len) {

            throw new Exception();
        }

        ///

        var next = new String(
            buffer
                .Skip(distance)
                .Take(equals.Length)
                .ToArray());

        if (next != equals) {

            return false;
        }

        ///

        var possibleWhitespace = buffer[equals.Length + distance];

        ///

        return IsWhiteSpace(possibleWhitespace);
    }

    ///

    public static bool MatchWithTrailingDelimiter(
        this IScanner scanner,
        String equals,
        Func<char, bool> delimitedBy,
        int distance = 0) {

        if (scanner.IsEof()) {

            return false;
        }

        ///

        var len = equals.Length + distance + 1;

        var end = scanner.Position + len;

        if (end > scanner.GetLength()) {

            return false;
        }

        ///

        var buffer = scanner.Peek(len);

        if (buffer.Length != len) {

            throw new Exception();
        }

        ///

        var next = new String(
            buffer
                .Skip(distance)
                .Take(equals.Length)
                .ToArray());

        if (next != equals) {

            return false;
        }

        ///

        var possibleWhitespace = buffer[equals.Length + distance];

        ///

        return delimitedBy(possibleWhitespace);
    }


    public static bool MatchNonEmptyWithTrailingDelimiter(
        this IScanner scanner,
        Func<char, bool> delimitedBy,
        int distance = 0) {

        var len = scanner.GetLength();

        ///

        var start = scanner.Position + distance;

        ///

        var i = start;

        ///

        switch (scanner) {

            case StringScanner stringScanner:

                while (i < len) {

                    if (delimitedBy(stringScanner.Source[i]) && i > start) {

                        return true;
                    }
                }

                break;


                ///

            case StreamScanner streamScanner:

                streamScanner.Source.Position = streamScanner.Position;

                streamScanner.Reader.SetPosition(streamScanner.Position);

                ///

                var nonEmptyDelimiterReached = false;

                while (i < len) {

                    if (delimitedBy(System.Convert.ToChar(streamScanner.Reader.Read())) && i > start) {

                        nonEmptyDelimiterReached = true;
                    }

                    ///

                    i++;
                }

                ///

                streamScanner.Source.Position = streamScanner.Position;

                streamScanner.Reader.SetPosition(streamScanner.Position);

                ///

                if (nonEmptyDelimiterReached) {

                    return true;
                }

                ///

                break;
                

                ///

            default:

                throw new Exception();
        }

        ///

        return false;
    }
}
