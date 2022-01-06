
namespace Neu;

public partial class NeuTokenizer {

    public static NeuAssignmentOperatorType? ToAssignmentOperatorType(
        NeuToken token) {

        switch (token) {

            case NeuPunc p when p.PuncType == NeuPuncType.Equal:
                return NeuAssignmentOperatorType.Assign;
            
            ///
            
            default:
                return null;
        }
    }

    public static NeuAssignmentOperator? ToAssignmentOperator(
        NeuToken token) {

        switch (ToAssignmentOperatorType(token)) {

            case NeuAssignmentOperatorType t:
                return new NeuAssignmentOperator(
                    source: token.Source,
                    start: token.Start,
                    end: token.End,
                    operatorType: t);

            ///

            default:
                return null;
        }
    }
}
