
namespace Neu;

public partial class NeuDeclaration: NeuStatement {

    public NeuDeclaration(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
