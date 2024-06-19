using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class ObjectGet : Node
{
    [IsArgOut]
    public object Value { get; set; } = null;

    public override void Execute()
    {
        var setNode = (ObjectSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
