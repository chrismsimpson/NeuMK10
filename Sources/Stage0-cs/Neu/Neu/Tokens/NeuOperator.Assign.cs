
namespace Neu;

public enum NeuAssignmentOperatorType {

    Assign
}

public partial class NeuAssignmentOperator: NeuOperator {
    
    public NeuAssignmentOperatorType OperatorType { get; init; }

    ///

    public NeuAssignmentOperator(
        Char source,
        SourceLocation start,
        SourceLocation end,
        NeuAssignmentOperatorType operatorType)
        : base(new String(new Char[] { source }), start, end) {

        this.OperatorType = operatorType;
    }

    public NeuAssignmentOperator(
        String source,
        SourceLocation start,
        SourceLocation end,
        NeuAssignmentOperatorType operatorType)
        : base(source, start, end) {
            
        this.OperatorType = operatorType;
    }
}