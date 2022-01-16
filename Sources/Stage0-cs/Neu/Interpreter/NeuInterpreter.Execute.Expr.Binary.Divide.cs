
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Divide(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Divide(lhsFloat, rhsFloat);
        }
        else if (lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt) {

            return Divide(lhsInt, rhsInt);
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

    public static NeuInteger Divide(
        NeuInteger lhs,
        NeuInteger rhs) {
            
        return new NeuInteger(lhs.Value / rhs.Value);
    }
}
