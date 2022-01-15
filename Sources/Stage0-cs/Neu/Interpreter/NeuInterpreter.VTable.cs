
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

        var func = new NeuFunc(name, moduleName, namespaceName, typeName, node);

        interpreter.VTable.Add(func);

        return func;
    }

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

        var op = new NeuOperation(name, moduleName, namespaceName, typeName, node);

        interpreter.VTable.Add(op);

        return op;
    }

    public static bool OperationExists(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName) {

        var nameIsNull = IsNullOrWhiteSpace(name);
        var moduleNameIsNull = IsNullOrWhiteSpace(moduleName);
        var namespaceNameIsNull = IsNullOrWhiteSpace(namespaceName);
        var typeNameIsNull = IsNullOrWhiteSpace(typeName);

        ///

        if (nameIsNull && moduleNameIsNull && namespaceNameIsNull && typeNameIsNull) {

            throw new Exception();
        }

        ///

        foreach (var op in interpreter.VTable) {

            var isMatch = interpreter.MatchOperation(
                name, nameIsNull, 
                moduleName, moduleNameIsNull, 
                namespaceName, namespaceNameIsNull, 
                typeName, typeNameIsNull, 
                op);

            if (isMatch) {

                return true;
            }
        }

        ///

        return false;
    }

    public static IEnumerable<NeuOperation> GetOperations(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName) {

        var nameIsNull = IsNullOrWhiteSpace(name);
        var moduleNameIsNull = IsNullOrWhiteSpace(moduleName);
        var namespaceNameIsNull = IsNullOrWhiteSpace(namespaceName);
        var typeNameIsNull = IsNullOrWhiteSpace(typeName);

        ///

        if (nameIsNull && moduleNameIsNull && namespaceNameIsNull && typeNameIsNull) {

            throw new Exception();
        }

        ///

        var ops = new List<NeuOperation>();

        ///

        foreach (var op in interpreter.VTable) {

            var isMatch = interpreter.MatchOperation(
                name, nameIsNull, 
                moduleName, moduleNameIsNull, 
                namespaceName, namespaceNameIsNull, 
                typeName, typeNameIsNull, 
                op);

            if (isMatch) {

                ops.Add(op);
                // yield return op;
            }
        }

        ///

        return ops;
    }

    public static bool MatchOperation(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        String? name,
        bool nameIsNull,
        String? moduleName,
        bool moduleNameIsNull,
        String? namespaceName,
        bool namespaceNameIsNull,
        String? typeName,
        bool typeNameIsNull,
        NeuOperation candidate) {

        var candidateNameIsNull = IsNullOrWhiteSpace(candidate.Name);
        var candidateModuleNameIsNull = IsNullOrWhiteSpace(candidate.ModuleName);
        var candidateNamespaceNameIsNull = IsNullOrWhiteSpace(candidate.NamespaceName);
        var candidateTypeNameIsNull = IsNullOrWhiteSpace(candidate.TypeName);

        ///

        if (candidateNameIsNull && candidateModuleNameIsNull && candidateNamespaceNameIsNull && candidateTypeNameIsNull ) {

            return false;
        }

        ///

            // ALL

        if (!nameIsNull &&
            !moduleNameIsNull &&
            !namespaceNameIsNull &&
            !typeNameIsNull && 
            !candidateNameIsNull && 
            !candidateModuleNameIsNull &&
            !candidateNamespaceNameIsNull && 
            !candidateTypeNameIsNull) {

            return candidate.Name == name &&
                candidate.ModuleName == moduleName &&
                candidate.NamespaceName == namespaceName &&
                candidate.TypeName == typeName;
        }

        ///

        return candidate.Name == name;

        //     // Module name missing

        //     // Namespace name missing

        //     // Type name missing

        //     ///

        //     /// Module name and namespace missing

        //     /// Namespace 

        // String? moduleName,
        // String? namespaceName,
        // String? typeName,


        // return 

    }
}