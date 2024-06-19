using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class IntGet : Node
{
    [IsArgOut]
    public int Value { get; set; }

    public override void Execute()
    {
        var setNode = (IntSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
