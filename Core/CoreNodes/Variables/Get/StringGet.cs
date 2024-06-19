using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class StringGet : Node
{
    [IsArgOut]
    public string Value { get; set; }

    public override void Execute()
    {
        var setNode = (StringSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
