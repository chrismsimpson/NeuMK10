
namespace Neu;

public static partial class IScannerFunctions {

    public static String NextWhile(
        this IScanner scanner, 
        Func<Char, bool> test) {

        var result = new StringBuilder();

        ///

        while (!scanner.IsEof() && test(scanner.Peek())) {

            result.Append(scanner.Next());
        }

        ///

        return result.ToString();
    }
}
