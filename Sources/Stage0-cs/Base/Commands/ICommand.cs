
namespace Base;

public interface ICommand {

    Task Run(
        IEnumerable<IArgument> arguments);
}