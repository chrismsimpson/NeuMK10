
namespace Base;

public static partial class IScannerFunctions {

    public static String NextWhitespace(
        this IScanner scanner) {

        return scanner.NextWhile(c => IsWhiteSpace(c));
    }

    public static String NextUntilWhitespace(
        this IScanner scanner) {

        return scanner.NextUntil(c => IsWhiteSpace(c));
    }

    public static String NextSpaceOrTabs(
        this IScanner scanner) {

        return scanner.NextWhile(c => IsSpaceOrTabs(c));
    }
}
