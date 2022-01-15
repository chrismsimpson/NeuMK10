
namespace Neu;

public partial class NeuInterpreter: Interpreter<NeuFrame, NeuOperation> {

    public NeuInterpreter()
        : base(new Stack<NeuFrame>(), new List<NeuOperation>()) { }
}