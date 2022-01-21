
namespace Neu;

public partial class NeuInterpreter: Interpreter<NeuFrame, NeuOperation> {

    public IList<NeuOperation> SourceOutput { get; init; }

    ///

    public NeuInterpreter()
        : base(new Stack<NeuFrame>(), new List<NeuOperation>()) {

        this.SourceOutput = new List<NeuOperation>();
    }
}