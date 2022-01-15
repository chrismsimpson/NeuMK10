
namespace Base;

public abstract class Interpreter<F, O>
    where F : Frame
    where O : IOperation {   

    public Stack<F> Stack { get; init; }

    public List<O> VTable { get; init; }

    ///

    public Interpreter(
        Stack<F> stack,
        List<O> vtable) {
            
        this.Stack = stack;
        this.VTable = vtable;
    }
}