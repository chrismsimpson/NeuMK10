
using System.Reflection;

namespace Neu;

public static partial class StreamReaderFunctions {

    public static int GetLocation(
        this StreamReader reader) {

        var type = reader.GetType();

        var flags = BindingFlags.DeclaredOnly | 
            BindingFlags.Public | 
            BindingFlags.NonPublic | 
            BindingFlags.Instance | 
            BindingFlags.GetField;

        return System.Convert.ToInt32(type.InvokeMember("_charPos", flags, null, reader, null));
    }

    public static int GetLength(
        this StreamReader reader) {

        var type = reader.GetType();

        var flags = BindingFlags.DeclaredOnly | 
            BindingFlags.Public | 
            BindingFlags.NonPublic | 
            BindingFlags.Instance | 
            BindingFlags.GetField;

        return System.Convert.ToInt32(type.InvokeMember("_charLen", flags, null, reader, null));
    }

    public static void SetPosition(
        this StreamReader reader,
        int value) {

        var type = reader.GetType();

        var flags = BindingFlags.DeclaredOnly | 
            BindingFlags.Public | 
            BindingFlags.NonPublic | 
            BindingFlags.Instance | 
            BindingFlags.SetField;

        type.InvokeMember("_charPos", flags, null, reader, new object[] { value });
    }

    public static void SetLength(
        this StreamReader reader,
        int value) {
            
        var type = reader.GetType();

        var flags = BindingFlags.DeclaredOnly | 
            BindingFlags.Public | 
            BindingFlags.NonPublic | 
            BindingFlags.Instance | 
            BindingFlags.SetField;

        type.InvokeMember("_charLen", flags, null, reader, new object[] { value });
    }
}
