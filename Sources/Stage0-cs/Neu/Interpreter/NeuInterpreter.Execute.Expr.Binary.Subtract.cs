
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Subtract(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Subtract(lhsFloat, rhsFloat);
        }
        else if (lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt) {

            return Subtract(lhsInt, rhsInt);
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

    public static NeuInteger Subtract(
        NeuInteger lhs,
        NeuInteger rhs) {
            
        return new NeuInteger(lhs.Value - rhs.Value);
    }
}
