
namespace Base;

public partial class PathComponent: PathToken {

    public PathComponent(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

public partial class ParentDirectoryComponent: PathComponent {

    public ParentDirectoryComponent(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

public partial class CurrentDirectoryComponent: PathComponent {

    public CurrentDirectoryComponent(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}
