
namespace Neu;

public partial class NeuTokenizer {

    public static bool IsNeuPrimitive(
        String? name) {

        switch (name) {

            case "Int":
                return true;

            ///

            case "Float":
                return true;

            ///

            case "Bool":
                return true;

            ///

            default:

                return false;
        }
    }
}