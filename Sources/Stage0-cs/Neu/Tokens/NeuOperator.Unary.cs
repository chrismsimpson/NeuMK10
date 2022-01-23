
namespace Neu;

public enum NeuUnaryOperatorType {

    Increment,
    Decrement,
    SizeOf
}

public partial class NeuUnaryOperator: NeuOperator {

    public NeuUnaryOperatorType OperatorType { get; init; }

    ///

    public NeuUnaryOperator(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        NeuUnaryOperatorType operatorType)
        : base(source, start, end) {
            
        this.OperatorType = operatorType;
    }
}