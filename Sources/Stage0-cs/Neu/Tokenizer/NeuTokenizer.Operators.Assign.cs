
namespace Neu;

public partial class NeuTokenizer {

    public static NeuAssignOperatorType? ToNeuAssignOperatorType(
        NeuToken token) {

        switch (token) {

            case NeuPunc p when p.PuncType == NeuPuncType.Equal:

                return NeuAssignOperatorType.Assign;

            ///

            default:

                return null;
        }
    }

    public static NeuAssignOperator? ToNeuAssignOperator(
        NeuToken token) {

        switch (ToNeuAssignOperatorType(token)) {

            case NeuAssignOperatorType t:

                return new NeuAssignOperator(
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
