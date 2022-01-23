
namespace Neu;

public partial class NeuSource: NeuNode {

    // public NeuSource() {

    //     throw new Exception();
    // }

    ///

    public NeuSource(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuSourceFunctions {

    public static NeuCodeBlockItemList? GetCodeBlockItemList(
        this NeuSource source) {

        return source.GetFirstOrDefault<NeuCodeBlockItemList>();
    }
}