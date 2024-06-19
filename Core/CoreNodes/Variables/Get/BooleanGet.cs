using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class BooleanGet : Node
{
    [IsArgOut] 
    public bool Value { get; set; }

    public override void Execute()
    {
        var setNode = (BooleanSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
