
namespace Neu;

public partial class NeuNumberLiteral: NeuLiteral {

    public NeuNumberLiteral(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

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