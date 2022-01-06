
namespace Base;

public static partial class PathTokenizerFunctions {

    private static PathComponent NextComponent(
        this Tokenizer<PathToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.NextWhile(c => IsPathComponentPart(c));

        ///

        return new PathComponent(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }

    ///

    private static ParentDirectoryComponent NextParentDirectoryComponent(
        this Tokenizer<PathToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();
        ///

        var source = tokenizer.Scanner.Next("..");

        ///

        return new ParentDirectoryComponent(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }

    private static CurrentDirectoryComponent NextCurrentDirectoryComponent(
        this Tokenizer<PathToken> tokenizer) {
            
        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.Next(".");

        ///

        return new CurrentDirectoryComponent(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }
}
