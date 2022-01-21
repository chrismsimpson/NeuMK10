
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuSizeOfExpression sizeOfExpr) {

        var typeId = sizeOfExpr.GetTypeIdentifier();

        ///

        switch (typeId) {

            case NeuSimpleTypeId simpleTypeId:

                return interpreter.Execute(simpleTypeId);

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuSimpleTypeId simpleTypeId) {

        var id = simpleTypeId.GetIdentifer();

        if (id == null) {

            throw new Exception();
        }

        ///

        switch (id.Source) {

            case "Float":

                return new NeuInteger(4);

            ///

            case "Int":

                return new NeuInteger(4);

            ///

            case "Bool":

                return new NeuInteger(1);
            
            ///

            default:
                
                throw new Exception();
        }
    }
}