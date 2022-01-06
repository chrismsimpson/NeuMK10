
namespace MLIR;

public partial class MLIRToken: Token {
    
    public MLIRToken(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}