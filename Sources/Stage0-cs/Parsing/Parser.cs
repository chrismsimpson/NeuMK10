
namespace Neu;

public abstract class Parser<T> where T: Token {

    public Tokenizer<T> Tokenizer { get; init; }

    ///

    public Parser(
        Tokenizer<T> tokenizer) {

        this.Tokenizer = tokenizer;
    }
}
