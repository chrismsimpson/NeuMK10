
namespace Base;

public partial class Argument: IArgument {

    public String Source { get; init; }

    public int Position { get; init; }

    ///

    public Argument(
        String source,
        int position) {

        this.Source = source;
        this.Position = position;
    }
}
