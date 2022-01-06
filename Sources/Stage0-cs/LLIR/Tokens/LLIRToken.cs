
namespace LLIR;
    
public partial class LLIRToken: Token {

    public LLIRToken(
        String source,
        SourceLocation start,
        SourceLocation end) 
        : base(source, start, end) { }
}
