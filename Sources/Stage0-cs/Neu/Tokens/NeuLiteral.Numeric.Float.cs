
namespace Neu;

public partial class NeuFloatLiteral: NeuNumberLiteral {
    
    public float Value { get; init; }

    ///

    public NeuFloatLiteral(
        String source,
        SourceLocation start,
        SourceLocation end,
        float value)
        : base(source, start, end) {

        this.Value = value;
    }
}
