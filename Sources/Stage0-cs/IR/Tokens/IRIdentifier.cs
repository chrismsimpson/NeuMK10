
namespace IR;

public class IRIdentifier: IRToken {

    public IRIdentifier(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}