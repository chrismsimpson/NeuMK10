
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuStatement statement) {

        switch (statement) {
           
            default:
                throw new Exception();
        }
    }
}
