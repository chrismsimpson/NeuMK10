
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuCallExpression callExpression) {

        var name = callExpression.GetName();

        if (IsNullOrWhiteSpace(name)) {

            throw new Exception();
        }

        ///

        var ops = interpreter.GetOperations(name, null, null, null);

        ///

        var callee = ops.SingleOrDefault() as NeuOperation;

        if (callee == null) {

            throw new Exception();
        }

        ///
        
        var args = callExpression.GetArguments();

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

        var evalArguments = new List<NeuArgument>();

        ///

        switch (true) {

            case var _ when args.Count() == 0 && calleeParamList.Count() == 0:

                break;

            ///

            default:

                throw new Exception();
        }

        ///

        return interpreter.Execute(callee, evalArguments);
    }
}
