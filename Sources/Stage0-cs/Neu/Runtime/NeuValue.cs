
namespace Neu;

public partial class NeuValue {

    public NeuValue() { } 
}

///

public partial class NeuValue {

    public static readonly NeuValue Void = new NeuVoid();
    // public static readonly NeuValue Null = new NeuNull();
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

            case NeuVoid _:
                return "void";

            ///

            default:
                return $"{value} (unknown)";
        }   
    }
}
