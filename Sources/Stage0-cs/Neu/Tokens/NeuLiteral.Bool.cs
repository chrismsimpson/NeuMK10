
namespace Neu;

public partial class NeuBoolLiteral: NeuLiteral {

    public bool Value { get; init; }

    ///

    public NeuBoolLiteral(
        String source,
        SourceLocation start,
        SourceLocation end,
        bool value)
        : base(source, start, end)
    {
        this.Value = value;
    }
}
