
namespace Base;

public partial class StringScanner: IScanner {

    public int Position { get; set; }

    public int LineNumber { get; set; }

    public int Column { get; set; }

    ///

    public String Source { get; init; }

    ///

    public StringScanner(
        String source) {

        this.Source = source;

        ///

        this.Position = 0;

        ///

        this.LineNumber = 1;

        this.Column = 1;
    }
}
