
namespace Neu;

public partial class NeuOperator: NeuToken {

    public NeuOperator(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}
