
namespace Neu;

public partial class NeuIntegerLiteral: NeuNumberLiteral {
    
    public int Value { get; init; }

    ///

    public NeuIntegerLiteral(
        String source,
        SourceLocation start,
        SourceLocation end,
        int value)
        : base(source, start, end) {
            
        this.Value = value;
    }
}
