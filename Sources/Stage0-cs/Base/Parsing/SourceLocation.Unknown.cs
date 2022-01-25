
namespace Base;

public partial class UnknownLocation: ISourceLocation {

    public int Position { get; init; }

    public int LineNumber { get; init; }

    public int Column { get; init; }

    ///

    public UnknownLocation() {

        this.Position = -1;
        this.LineNumber = -1;
        this.Column = -1;
    }
}
