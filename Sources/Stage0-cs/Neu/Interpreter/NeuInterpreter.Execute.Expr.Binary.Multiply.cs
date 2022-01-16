
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Multiply(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Multiply(lhsFloat, rhsFloat);
        }
        else if (lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt) {

            return Multiply(lhsInt, rhsInt);
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

    public static NeuInteger Multiply(
        NeuInteger lhs,
        NeuInteger rhs) {

        return new NeuInteger(lhs.Value * lhs.Value);
    }
}
