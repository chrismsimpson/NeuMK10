
namespace Neu;

public partial class NeuAssignmentExpression: NeuInfixExpression {

    public NeuAssignmentExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
