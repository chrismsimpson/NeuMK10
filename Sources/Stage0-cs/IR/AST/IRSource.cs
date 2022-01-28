
namespace IR;

public partial class IRSource: IRNode {

    public IRSource(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}