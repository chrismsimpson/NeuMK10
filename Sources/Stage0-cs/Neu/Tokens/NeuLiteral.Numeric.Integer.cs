
namespace Neu;

public partial class NeuIntegerLiteral: NeuNumberLiteral {
    
    public int Value { get; init; }

    ///

    public NeuIntegerLiteral(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        int value)
        : base(source, start, end) {
            
        this.Value = value;
    }
}
