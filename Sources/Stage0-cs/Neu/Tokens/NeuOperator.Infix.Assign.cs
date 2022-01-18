
namespace Neu;

public enum NeuAssignOperatorType {

    Assign
}

public partial class NeuAssignOperator: NeuInfixOperator {
    
    public NeuAssignOperatorType OperatorType { get; init; }

    ///

    public NeuAssignOperator(
        Char source,
        SourceLocation start,
        SourceLocation end,
        NeuAssignOperatorType operatorType)
        : base(new String(new Char[] { source }), start, end) {

        this.OperatorType = operatorType;
    }

    public NeuAssignOperator(
        String source,
        SourceLocation start,
        SourceLocation end,
        NeuAssignOperatorType operatorType)
        : base(source, start, end) {
            
        this.OperatorType = operatorType;
    }
}

///

public static partial class NeuAssignOperatorFunctions {

    public static int GetPrecedence(
        this NeuAssignOperator assignOp) {

        switch (assignOp.OperatorType) {

            case NeuAssignOperatorType.Assign:

                return 0;

            ///

            default:

                throw new Exception();
        }
    }
}