
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuCallExpression callExpression) {

        var name = callExpression.GetName();

        if (IsNullOrWhiteSpace(name)) {

            throw new Exception();
        }


        ///
        
        var rawArgs = callExpression.GetArguments();

        ///

        return interpreter.Call(name, rawArgs);

        // ///




        // ///

        // if (IsNeuPrimitive(name)) {


        // }

    }

    public static NeuOperation Call(
        this NeuInterpreter interpreter,
        String name,
        IEnumerable<Node> rawArgs) {

        var evalArguments = new List<NeuArgument>();

        ///

        foreach (var rawArg in rawArgs) {

            var argValue = interpreter.Execute(rawArg);

            ///

            var arg = new NeuArgument(null, argValue);

            ///

            evalArguments.Add(arg);
        }

        ///

        switch (true) {

            case var _ when IsNeuPrimitive(name):

                return interpreter.CallPrimitive(name, rawArgs, evalArguments);

            ///

            default:

                return interpreter.CallVTable(name, rawArgs, evalArguments);
        }
    }

    public static NeuOperation CallPrimitive(
        this NeuInterpreter interpreter,
        String name,
        IEnumerable<Node> rawArgs,
        IList<NeuArgument> evalArguments) {

        switch (name) {

            case "Bool":

                var bl = evalArguments.SingleOrDefault()?.Value as NeuBool;

                if (bl == null) {

                    throw new Exception();
                }

                return bl;







            ///

            case "Int":

                var i = evalArguments.SingleOrDefault()?.Value as NeuInteger;

                if (i == null) {

                    throw new Exception();
                }

                return i;








            ///

            case "Float":

                var floatVal = evalArguments.SingleOrDefault();

                ///

                switch (floatVal?.Value) {

                    case NeuInteger fi:

                        return new NeuFloat(Convert.ToSingle(fi.Value));

                    ///

                    case NeuFloat f:

                        return f;

                    ///

                    default:

                        throw new Exception();

                }


                

            // case "Int":

                // var i = evalArguments.SingleOrDefault() as? 

                // if (i == null) {

                //     throw new Exception();
                // }

                // return new NeuInteger(i);

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuOperation CallVTable(
        this NeuInterpreter interpreter,
        String name,
        IEnumerable<Node> rawArgs,
        IList<NeuArgument> evalArguments) {
        
        ///

        var ops = interpreter.GetOperations(name, null, null, null);

        ///

        var callee = ops.SingleOrDefault() as NeuOperation;

        if (callee == null) {

            throw new Exception();
        }

        ///

        var calleeeParamClause = callee.GetParamClause();

        if (calleeeParamClause == null) {

            throw new Exception();
        }

        ///

        var calleeParamList = calleeeParamClause.GetFuncParamList();

        if (calleeParamList == null) {

            throw new Exception();
        }

        ///

        switch (true) {

            case var _ when rawArgs.Count() == 0 && calleeParamList.Count() == 0:

                break;

            ///

            default:

                throw new Exception();
        }

        ///

        return interpreter.Execute(callee, evalArguments);
    }


    // public static NeuOperation Execute(
    //     this NeuInterpreter interpreter,
    //     NeuCallExpression callExpression) {

    //     var name = callExpression.GetName();

    //     if (IsNullOrWhiteSpace(name)) {

    //         throw new Exception();
    //     }

    //     ///

    //     var ops = interpreter.GetOperations(name, null, null, null);

    //     ///

    //     var callee = ops.SingleOrDefault() as NeuOperation;

    //     if (callee == null) {

    //         throw new Exception();
    //     }

    //     ///
        
    //     var args = callExpression.GetArguments();

    //     ///

    //     var calleeeParamClause = callee.GetParamClause();

    //     if (calleeeParamClause == null) {

    //         throw new Exception();
    //     }

    //     ///

    //     var calleeParamList = calleeeParamClause.GetFuncParamList();

    //     if (calleeParamList == null) {

    //         throw new Exception();
    //     }
        
    //     ///

    //     var evalArguments = new List<NeuArgument>();

    //     ///

    //     switch (true) {

    //         case var _ when args.Count() == 0 && calleeParamList.Count() == 0:

    //             break;

    //         ///

    //         default:

    //             throw new Exception();
    //     }

    //     ///

    //     return interpreter.Execute(callee, evalArguments);
    // }
}
