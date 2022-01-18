
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Add(
        this NeuInterpreter interpreter,
        NeuOperation lhs,
        NeuOperation rhs) {

        switch (true) {

            case var _ 
                when
                    lhs is NeuFloat lhsFloat && rhs is NeuFloat rhsFloat:

                return interpreter.Add(lhsFloat, rhsFloat);

            ///

            case var _ when 
                    lhs is NeuInteger lhsInt && rhs is NeuInteger rhsInt:  

                return interpreter.Add(lhsInt, rhsInt);
        
            ///

            default:

                throw new Exception();
        }
    }

    public static NeuFloat Add(
        this NeuInterpreter interpreter,
        NeuFloat lhs,
        NeuFloat rhs) {
            
        return new NeuFloat(lhs.Value + rhs.Value);
    }

    public static NeuInteger Add(
        this NeuInterpreter interpreter,
        NeuInteger lhs,
        NeuInteger rhs) {
            
        return new NeuInteger(lhs.Value + rhs.Value);
    }
}
