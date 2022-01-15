
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Divide(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Divide(lhsFloat, rhsFloat);
        }
        else {

            throw new Exception();
        }
    }

    public static NeuFloat Divide(
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value / rhs.Value);
    }
}
