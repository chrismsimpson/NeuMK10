
namespace Neu;

public partial class NeuBasicArrayTestCommand: NeuTestsCommand {

    public NeuBasicArrayTestCommand() { }

    ///

    public override async Task Run(
        IEnumerable<IArgument> arguments) {

        await Task.Run(() => {

            var (filename, result) = this.Evaluate(arguments);

            ///

            var arrayResult = result as NeuArray;

            if (arrayResult == null) {

                throw new Exception();
            }

            ///

            if (arrayResult.Elements.Count() != 3) {
                
                throw new Exception();
            }

            ///

            if (!(arrayResult.ElementAt(0) is NeuInteger e0 && e0.Value == 1)) {

                throw new Exception();
            }

            ///

            if (!(arrayResult.ElementAt(1) is NeuInteger e1 && e1.Value == 2)) {

                throw new Exception();
            }

            ///

            if (!(arrayResult.ElementAt(2) is NeuInteger e2 && e2.Value == 3)) {

                throw new Exception();
            }

            ///

            var silent = arguments.Get("--silent") == null
                ? false
                : true;

            if (!silent) {
            
                WriteLine($"  Test {filename} successful\n");
            }
        });
    }
}
