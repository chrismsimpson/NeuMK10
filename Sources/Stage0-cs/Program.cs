
namespace Neu;

public static partial class Program {

    public static void Main(
        String[] args) {

        var n = GetTestsDirectory("Neu");

        var f = Combine(n, "test00.neu");

        var s = NeuParser.FromFile(f);

        var s2 = s.ParseSource();

        WriteLine($"{s2.Dump()}");
    }
}