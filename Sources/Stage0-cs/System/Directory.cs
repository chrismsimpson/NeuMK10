
namespace Neu;

public static partial class DirectoryFunctions {

    public static String GetTestsDirectory(
        String? subdirectory = null) {

        var sources = GetCurrentDirectory();

        ///

        var root = GetParent(sources);

        if (root == null) {

            throw new Exception();
        }

        ///

        var tests = Combine(root.FullName, "Tests");

        if (!IsNullOrWhiteSpace(subdirectory)) {
        
            tests = Combine(tests, subdirectory);
        }

        return tests;
    }
}