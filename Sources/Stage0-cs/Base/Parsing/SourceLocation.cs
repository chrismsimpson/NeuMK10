
namespace Base;

public interface ISourceLocation {

    int Position { get; init; }

    int LineNumber { get; init; }

    int Column { get; init; }
}

public partial class SourceLocation: ISourceLocation {

    public int Position { get; init; }

    public int LineNumber { get; init; }

    public int Column { get; init; }

    ///

    public long Ticks { get; init; }

    ///

    public SourceLocation(
        int position,
        int lineNumber,
        int column) {

        this.Position = position;
        this.LineNumber = lineNumber;
        this.Column = column;
        
        ///

        this.Ticks = UtcNow.UtcTicks;
    }
}

///

public partial class SourceLocation {

    public static bool AreEqual(
        ISourceLocation lhs,
        ISourceLocation rhs) {
            
        return lhs.Position == rhs.Position;
    }
}
