
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuHoistedFrame Hoist(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        NeuKeywordType keywordType,
        String name,
        NeuOperation operation) {

        var hoist = new NeuHoist(keywordType, name);

        ///

        var hoistedFrame = new NeuHoistedFrame(hoist, operation);

        ///

        interpreter.Stack.Push(hoistedFrame);

        ///

        return hoistedFrame;
    }
}