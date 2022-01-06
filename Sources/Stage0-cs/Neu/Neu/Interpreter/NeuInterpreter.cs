
namespace Neu;

public partial class NeuInterpreter: Interpreter<NeuFrame> {

    public NeuInterpreter()
        : base (new Stack<NeuFrame>()) {

    }
}