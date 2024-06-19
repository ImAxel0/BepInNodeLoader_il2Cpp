using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.Rigidbody;

public class RbIsKinematic : Node
{
    [IsArgOut]
    public bool IsKinematic { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var rb = (UnityEngine.Rigidbody)args[0];
        IsKinematic = rb.isKinematic;
    }
}
