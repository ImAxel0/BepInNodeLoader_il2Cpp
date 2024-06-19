using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class FloatGet : Node
{
    [IsArgOut]
    public float Value { get; set; }

    public override void Execute()
    {
        var setNode = (FloatSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
