
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Add(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Add(lhsFloat, rhsFloat);
        }
        else if (lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt) {

            return Add(lhsInt, rhsInt);
        }
        else {

            throw new Exception();
        }
    }

    public static NeuFloat Add(
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value + rhs.Value);
    }

    public static NeuInteger Add(
        NeuInteger lhs,
        NeuInteger rhs) {
            
        return new NeuInteger(lhs.Value + rhs.Value);
    }
}
