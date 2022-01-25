
namespace Neu;

public enum NeuKeywordType {

    Func,
    Return,
    Var,
    Let,

    True,
    False,

    SizeOf
}

public partial class NeuKeyword: NeuToken {

    public NeuKeywordType KeywordType { get; init; }

    ///

    public NeuKeyword(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        NeuKeywordType keywordType)
        : base(source, start, end) {
            
        this.KeywordType = keywordType;
    }

    ///

    public NeuKeyword(
        String source,
        NeuKeywordType keywordType)
        : base(source, new UnknownLocation(), new UnknownLocation()) {

        this.KeywordType = keywordType;
    }
}
