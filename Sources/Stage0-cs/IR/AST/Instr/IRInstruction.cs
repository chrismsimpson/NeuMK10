
namespace IR;

public partial class IRInstruction: IRCodeBlockItem {

    public IRInstruction(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
