
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuFunc? CreateFunc(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode node) {

        if (interpreter.OperationExists(name, moduleName, namespaceName, typeName)) {

            throw new Exception();
        }

        ///

        var func = new NeuFunc(name, moduleName, namespaceName, typeName, node, false, true);

        interpreter.VTable.Add(func);

        return func;
    }
}