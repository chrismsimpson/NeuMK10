
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuVar? CreateVar(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuOperation value) {

        if (interpreter.OperationExists(name, moduleName, namespaceName, typeName)) {

            throw new Exception();
        }

        ///

        var v = new NeuVar(name, value);

        interpreter.VTable.Add(v);

        return v;
    }
}