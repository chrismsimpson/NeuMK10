
namespace IR;

public class IRGlobalIdentifier: IRToken {

    public IRGlobalIdentifier(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}