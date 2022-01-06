
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

            case NeuInteger i:
                return $"int: {i.Value}";

            ///

            case NeuVoid _:
                return "void";

            ///

            default:
                return $"unknown: {value}";
        }   
    }
}
