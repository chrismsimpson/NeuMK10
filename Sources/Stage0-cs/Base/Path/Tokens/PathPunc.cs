
namespace Base;

public enum PathPuncType {

    Slash,
    Backslash
}

public partial class PathPunc: PathToken {

    public PathPuncType PuncType { get; init; }

    ///

    public PathPunc(
        Char source,
        SourceLocation start,
        SourceLocation end,
        PathPuncType puncType)
        : base(new String(new Char[] { source }), start, end) {

        this.PuncType = puncType;
    }

    public PathPunc(
        String source,
        SourceLocation start,
        SourceLocation end,
        PathPuncType puncType)
        : base(source, start, end) {
            
        this.PuncType = puncType;
    }
}
