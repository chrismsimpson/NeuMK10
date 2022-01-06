
namespace Neu;

public partial class NeuCodeBlockItem: NeuNode {

    public NeuCodeBlockItem(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public partial class NeuCodeBlockItemList: NeuNode {

    public NeuCodeBlockItemList(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public partial class NeuCodeBlock: NeuNode {

    public NeuCodeBlock(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
