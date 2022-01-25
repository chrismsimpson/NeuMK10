
namespace Neu;

public partial class NeuSource: NeuNode {

    public NeuSource(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuSource(
        NeuCodeBlockItemList codeBlockItemList)
        : base(new Node[] { codeBlockItemList }, new UnknownLocation(), new UnknownLocation()) { }
}

///

public static partial class NeuSourceFunctions {

    public static NeuCodeBlockItemList? GetCodeBlockItemList(
        this NeuSource source) {

        return source.GetFirstOrDefault<NeuCodeBlockItemList>();
    }
}