
namespace Neu;

public partial class NeuFloatLiteral: NeuNumberLiteral {
    
    public float Value { get; init; }

    ///

    public NeuFloatLiteral(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        float value)
        : base(source, start, end) {

        this.Value = value;
    }
}
