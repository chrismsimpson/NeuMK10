
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuDeclaration declaration) {

        switch (declaration) {

            case NeuFuncDecl funcDecl:

                return interpreter.Execute(funcDecl);

            ///

            case NeuVarDecl varDecl:

                return interpreter.Execute(varDecl);

            ///
            
            default:
            
                throw new Exception();
        }
    }
}
