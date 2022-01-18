
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuVar? HoistVar(
        this Interpreter<NeuFrame, NeuOperation> interpreter,
        NeuKeywordType keywordType,
        String name,
        NeuOperation value) {

        var v = new NeuVar(name, value);

        ///

        interpreter.Hoist(keywordType, name, v);

        ///

        return v;
    }
}