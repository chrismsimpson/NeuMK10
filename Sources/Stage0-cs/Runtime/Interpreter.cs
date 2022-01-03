
namespace Neu;

public abstract class Interpreter<F>
    where F : Frame {   

    internal Stack<F> Stack { get; init; }

    ///

    public Interpreter(
        Stack<F> stack) {
            
        this.Stack = stack;
    }
}