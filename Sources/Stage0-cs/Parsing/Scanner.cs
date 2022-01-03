
namespace Neu;

public interface IScanner {

    int Position { get; set; }

    int LineNumber { get; set; }

    int Column { get; set; }
}

///

public static partial class IScannerFunctions {

    public static bool IsZeroThruTen(
        Char c) {

        return c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9';
    }

    public static bool IsSpaceOrTabs(
        Char c) {

        return c == ' ' || c == '\t';
    }

    ///

    public static SourceLocation GetLocation(
        this IScanner scanner) {

        return new SourceLocation(
            position: scanner.Position,
            lineNumber: scanner.LineNumber,
            column: scanner.Column);
    }

    ///

    public static bool IsEof(
        this IScanner scanner) {

        switch (scanner) {

            case StringScanner stringScanner:
                return stringScanner.Position >= stringScanner.Source.Length;

            ///

            case StreamScanner streamScanner:
                return streamScanner.Position >= streamScanner.Source.Length;

            ///

            default:
                throw new Exception();
        }
    }

    ///

    public static int GetLength(
        this IScanner scanner) {

        switch (scanner) {

            case StringScanner stringScanner:

                return stringScanner.Source.Length;


            ///

            case StreamScanner streamScanner:

                return System.Convert.ToInt32(streamScanner.Source.Length);


            ///

            default:
                throw new Exception();
        }
    }

    ///

    public static void IncrementForBuffer(
        this IScanner scanner,
        Char[] buffer) {

        for (var i = 0; i < buffer.Length; i++) {

            var c = buffer[i];

            ///

            switch (c) {

                case '\n':

                    scanner.LineNumber++;

                    scanner.Column = 0;

                    break;

                    ///

                default:

                    scanner.Column++;

                    break;
            }

            ///

            scanner.Position++;
        }
    }
}
