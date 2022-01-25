
namespace IR;

public partial class IRNode: Node {

    public IRNode(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}