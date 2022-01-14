
namespace Neu;

public enum NeuBinaryOperatorType {

    Multiply,
    Divide,
    Add,
    Subtract
}

public partial class NeuBinaryOperator: NeuOperator {

    public NeuBinaryOperatorType OperatorType { get; init; }

    ///

    public NeuBinaryOperator(
        Char source,
        SourceLocation start,
        SourceLocation end,
        NeuBinaryOperatorType operatorType)
        : base(new String(new Char[] { source }), start, end) {

        this.OperatorType = operatorType;
    }

    public NeuBinaryOperator(
        String source,
        SourceLocation start,
        SourceLocation end,
        NeuBinaryOperatorType operatorType)
        : base(source, start, end) {
            
        this.OperatorType = operatorType;
    }
}

///

public static partial class NeuBinaryOperatorFunctions {

    public static int GetPrecedence(
        this NeuBinaryOperator op) {

        switch (op.OperatorType) {

            case NeuBinaryOperatorType.Multiply:
            case NeuBinaryOperatorType.Divide:
                return 15;

            case NeuBinaryOperatorType.Add:
            case NeuBinaryOperatorType.Subtract:
                return 14;

            default:
                return 0;
        }   
    }
}