
namespace Neu;

public partial class NeuFunc: NeuOperation, IFunction {

    public NeuFunc(
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode? node,
        bool writable,
        bool executable)
        : base(name, moduleName, namespaceName, typeName, node, writable, executable) { }
}