
namespace Neu;

public partial class NeuAssignmentExpression: NeuExpression {

    public NeuAssignmentExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
