
namespace Neu;

public partial class NeuParser: Parser<NeuToken> {

    public NeuParser(
        NeuTokenizer tokenizer)
        : base(tokenizer) { }
}