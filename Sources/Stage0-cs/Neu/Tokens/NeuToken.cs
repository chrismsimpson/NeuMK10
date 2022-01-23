
namespace Neu;
    
public partial class NeuToken: Token {

    public NeuToken(
        String source,
        ISourceLocation start,
        ISourceLocation end) 
        : base(source, start, end) { }
}
