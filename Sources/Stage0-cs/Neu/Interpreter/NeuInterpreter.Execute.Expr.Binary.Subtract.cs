
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Subtract(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Subtract(lhsFloat, rhsFloat);
        }
        else {

            throw new Exception();
        }
    }

    public static NeuFloat Subtract(
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value - rhs.Value);
    }
}
