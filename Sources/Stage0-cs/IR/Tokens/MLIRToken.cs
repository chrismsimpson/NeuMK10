
namespace IR;

public partial class IRToken: Token {
    
    public IRToken(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}