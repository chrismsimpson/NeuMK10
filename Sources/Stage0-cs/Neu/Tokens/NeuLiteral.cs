
namespace Neu;

public partial class NeuLiteral: NeuToken {
    
    public NeuLiteral(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}
