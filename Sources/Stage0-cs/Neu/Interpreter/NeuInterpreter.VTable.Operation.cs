
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation? CreateOperation(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode node) {

        if (interpreter.OperationExists(name, moduleName, namespaceName, typeName)) {

            throw new Exception();
        }

        ///

        var op = new NeuOperation(name, moduleName, namespaceName, typeName, node, false, true);

        interpreter.VTable.Add(op);

        return op;
    }
}