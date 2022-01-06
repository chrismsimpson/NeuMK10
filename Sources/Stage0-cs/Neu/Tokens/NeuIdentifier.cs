
namespace Neu;

public class NeuIdentifier: NeuToken {
    
    public NeuIdentifier(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}
