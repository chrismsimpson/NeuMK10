
namespace Neu;

public static partial class IScannerFunctions {

    public static char Peek(
        this IScanner scanner) {

        var next = scanner.Peek(length: 1);

        if (next.Length != 1) {

            throw new Exception();
        }

        return next[0];
    }

    public static Char[] Peek(
        this IScanner scanner,
        int length) {

        var end = scanner.Position + length;

        if (end > scanner.GetLength()) {

            throw new Exception();
        }

        ///

        switch (scanner) {

            case StringScanner stringScanner:

                var stringBuffer = new Char[length];

                for (var i = 0; i < length; i++) {

                    stringBuffer[i] = stringScanner.Source[scanner.Position + i];
                }

                return stringBuffer;


            ///

            case StreamScanner streamScanner:

                var sourceBuffer = new Char[length];

                ///

                streamScanner.Source.Position = streamScanner.Position;

                streamScanner.Reader.SetPosition(streamScanner.Position);

                ///

                for (var i = 0; i < length; i++) {

                    sourceBuffer[i] = System.Convert.ToChar(streamScanner.Reader.Read());
                }

                ///

                streamScanner.Source.Position = streamScanner.Position;

                streamScanner.Reader.SetPosition(streamScanner.Position);

                ///

                return sourceBuffer;

            ///

            default:

                throw new Exception();
        }
    }
}
