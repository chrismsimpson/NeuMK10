
namespace Neu;

public partial class NeuGenericArg: NeuNode {

    public NeuGenericArg(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
