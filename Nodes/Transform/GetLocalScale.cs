using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class GetLocalScale : Node
{
    [IsArgOut]
    public Vector3 LocalScale { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        LocalScale = new Vector3(tr.localScale.x, tr.localScale.y, tr.localScale.z);
    }
}
