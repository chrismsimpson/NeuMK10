
namespace IR;

public partial class IRCodeBlockItem: IRNode {

    public IRCodeBlockItem(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public partial class IRCodeBlockItemList: IRNode {

    public IRCodeBlockItemList(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public partial class IRCodeBlock: IRNode {

    public IRCodeBlock(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}