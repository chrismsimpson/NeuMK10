
namespace Neu;

public class NeuIdentifier: NeuToken {
    
    public NeuIdentifier(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}
