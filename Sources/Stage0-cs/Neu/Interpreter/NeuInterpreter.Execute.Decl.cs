
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuDeclaration declaration) {

        switch (declaration) {

            case NeuFuncDecl funcDecl:
                return interpreter.Execute(funcDecl);

            ///

            // case NeuVarDecl varDecl:
            //     return interpreter.Execute(varDecl);

            ///
            
            default:
                throw new Exception();
        }
    }

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuFuncDecl funcDecl) {

        var name = funcDecl.GetName();

        if (name == null) {

            throw new Exception();
        }

        ///

        var func = new NeuFunc(name, funcDecl);

        ///

        return func;
    }
}
