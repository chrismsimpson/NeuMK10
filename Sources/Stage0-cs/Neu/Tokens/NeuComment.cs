
namespace Neu;

public partial class NeuComment: NeuToken {

    public NeuComment(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}