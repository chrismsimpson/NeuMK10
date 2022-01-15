
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Add(
        NeuValue lhs,
        NeuValue rhs) {

        if (lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat) {

            return Add(lhsFloat, rhsFloat);
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
}
