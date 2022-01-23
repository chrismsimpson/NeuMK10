
namespace Neu;

public partial class NeuNumberLiteral: NeuLiteral {

    public NeuNumberLiteral(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}
