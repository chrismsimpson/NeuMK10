
namespace Neu;

public partial class NeuNumberLiteral: NeuLiteral {

    public NeuNumberLiteral(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}
