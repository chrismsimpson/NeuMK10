
namespace Base;

public interface IOperation {
    
    String? Name { get; init; }

    String? ModuleName { get; init; }

    String? NamespaceName { get; init; }

    String? TypeName { get; init; }

    Node? Node { get; init; }

    bool Writable { get; init; }

    bool Executable { get; init; }
}