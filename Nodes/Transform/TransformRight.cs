using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class TransformRight : Node
{
    [IsArgOut]
    public Vector3 Right { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        Right = new Vector3(tr.right.x, tr.right.y, tr.right.z);
    }
}
