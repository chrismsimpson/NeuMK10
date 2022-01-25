
namespace IR;

public static partial class Program {

    public static async Task Main(
        String[] args) {

        WriteLine($"Hello IR!");

        await Task.Run(() => {});
    }
}