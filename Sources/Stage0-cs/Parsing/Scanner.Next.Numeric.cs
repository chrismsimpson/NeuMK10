
namespace Neu;

public static partial class IScannerFunctions {

    public static String NextZeroThruTen(
        this IScanner scanner) {

        return scanner.NextWhile(c => IsZeroThruTen(c));
    }
}
