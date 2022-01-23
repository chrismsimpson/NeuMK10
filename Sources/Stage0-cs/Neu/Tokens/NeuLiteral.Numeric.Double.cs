
namespace Neu;

public partial class NeuDoubleLiteral: NeuNumberLiteral {
    
    public double Value { get; init; }

    ///

    public NeuDoubleLiteral(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        double value)
        : base(source, start, end) {
            
        this.Value = value;
    }
}