
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Subtract(
        this NeuInterpreter interpreter,
        NeuOperation lhs,
        NeuOperation rhs) {

        switch (true) {

            case var _ 
                when
                    lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat:

                return interpreter.Subtract(lhsFloat, rhsFloat);

            ///

            case var _ when 
                    lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt:  

                return interpreter.Subtract(lhsInt, rhsInt);

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuFloat Subtract(
        this NeuInterpreter interpreter,
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value - rhs.Value);
    }

    public static NeuInteger Subtract(
        this NeuInterpreter interpreter,
        NeuInteger lhs,
        NeuInteger rhs) {
            
        return new NeuInteger(lhs.Value - rhs.Value);
    }
}
