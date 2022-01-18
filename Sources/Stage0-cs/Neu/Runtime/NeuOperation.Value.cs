
namespace Neu;

public partial class NeuValue: NeuOperation {

    public NeuValue()
        : base(null, null, null, null, null, false, false) { }
}

///

public static partial class NeuValueFunctions {

    public static String Dump(
        this NeuValue value) {

        switch (value) {

            case NeuFloat f:
                return $"{f.Value} (Float)";

            ///

            case NeuInteger i:
                return $"{i.Value} (Int)";

            ///

            default:
                return $"{value} (unknown)";
        }   
    }
}
