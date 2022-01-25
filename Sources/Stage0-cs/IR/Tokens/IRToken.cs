
namespace IR;

public partial class IRToken: Token {

    public IRToken(
        String source,
        ISourceLocation start,
        ISourceLocation end)
        : base(source, start, end) { }
}