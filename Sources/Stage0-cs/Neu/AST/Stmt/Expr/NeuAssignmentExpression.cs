
namespace Neu;

public partial class NeuAssignmentExpression: NeuInfixExpression {

    public NeuAssignmentExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
