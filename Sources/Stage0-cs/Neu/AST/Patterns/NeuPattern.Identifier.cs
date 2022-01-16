
namespace Neu;

public partial class NeuIdentifierPattern: NeuPattern {

    public NeuIdentifierPattern(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}