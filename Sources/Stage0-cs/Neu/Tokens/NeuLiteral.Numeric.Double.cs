
namespace Neu;

public partial class NeuDoubleLiteral: NeuNumberLiteral {
    
    public double Value { get; init; }

    ///

    public NeuDoubleLiteral(
        String source,
        SourceLocation start,
        SourceLocation end,
        double value)
        : base(source, start, end) {
            
        this.Value = value;
    }
}