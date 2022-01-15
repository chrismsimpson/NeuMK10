
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Multiply(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Multiply(lhsFloat, rhsFloat);
        }
        else {

            throw new Exception();
        }
    }

    public static NeuFloat Multiply(
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value * rhs.Value);
    }
}
