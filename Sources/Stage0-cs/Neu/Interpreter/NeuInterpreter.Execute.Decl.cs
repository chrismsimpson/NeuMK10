
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuDeclaration declaration) {

        switch (declaration) {
            
            default:
                throw new Exception();
        }
    }
}
