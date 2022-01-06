
namespace Base;

public partial class Path {

    public IEnumerable<PathToken> Tokens { get; init; }

    ///

    public Path(
        IEnumerable<PathToken> tokens) {

        this.Tokens = tokens;
    }
}

///

public static partial class PathFunctions {
    
    public static Path GetCurrentDirectoryPath() {

        var currentDir = GetCurrentDirectory();

        var parser = PathParser.FromString(currentDir);

        return parser.ParsePath();
    }
}
