
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

// public static partial class NeuValueFunctions {

//     public static String Dump(
//         this NeuValue value) {

//         switch (value) {
            
//             case NeuBoolean b:
//                 return b.Value 
//                     ? "true"
//                     : "false";

//             ///

//             case NeuString s:
//                 return s.Value;

//             ///

//             case NeuFloat f:
//                 return $"{f.Value}";

//             ///

//             case NeuNull _:
//                 return "null";

//             ///

//             case NeuUndefined _:
//                 return "undefined";

//             ///

//             case NeuObject o:
//                 return $"object";

//             ///

//             case NeuInteger i:
//                 return $"{i.Value}";

//             ///

//             default:
//                 throw new Exception();
//         }   
//     }
// }