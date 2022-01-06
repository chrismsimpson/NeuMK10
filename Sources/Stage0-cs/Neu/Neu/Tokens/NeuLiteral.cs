
namespace Neu;

public partial class NeuLiteral: NeuToken {
    
    public NeuLiteral(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}
