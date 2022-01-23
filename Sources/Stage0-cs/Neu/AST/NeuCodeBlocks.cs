
namespace Neu;

public partial class NeuCodeBlockItem: NeuNode {

    public NeuCodeBlockItem(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public partial class NeuCodeBlockItemList: NeuNode {

    public NeuCodeBlockItemList(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public partial class NeuCodeBlock: NeuNode {

    public NeuCodeBlock(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
