
namespace IR;

public class IRLocalIdentifier: IRToken {

    public IRLocalIdentifier(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}