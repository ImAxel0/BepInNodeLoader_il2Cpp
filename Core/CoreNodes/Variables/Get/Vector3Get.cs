using System.Numerics;
using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

[IsGetVariable]
public class Vector3Get : Node
{
    [IsArgOut]
    public Vector3 Value { get; set; }

    public override void Execute()
    {
        var setNode = (Vector3Set)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
