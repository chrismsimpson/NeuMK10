
namespace Neu;

public partial class StreamScanner: IScanner {

    public int Position { get; set; }

    public int LineNumber { get; set; }

    public int Column { get; set; }

    ///

    public Stream Source { get; init; }

    public StreamReader Reader { get; init; }

    ///

    public StreamScanner(
        Stream source) {

        this.Source = source;

        ///

        this.Reader = new StreamReader(this.Source);

        ///

        this.Position = 0;

        ///

        this.LineNumber = 1;

        this.Column = 1;
    }

    ///

    ~StreamScanner() {

        this.Reader.Dispose();

        this.Source.Dispose();
    }
}
