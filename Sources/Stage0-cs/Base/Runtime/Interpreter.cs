
namespace Base;

public abstract class Interpreter<F>
    where F : Frame {   

    public Stack<F> Stack { get; init; }

    ///

    public Interpreter(
        Stack<F> stack) {
            
        this.Stack = stack;
    }
}