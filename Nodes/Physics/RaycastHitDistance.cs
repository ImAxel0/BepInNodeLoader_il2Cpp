using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using UnityEngine;

namespace BepInNodeLoaderIl2Cpp.Nodes.Physics;

public class RaycastHitDistance : Node
{
    [IsArgOut]
    public float Distance { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var hitInfo = (RaycastHit)args[0];
        Distance = hitInfo.distance;
    }
}
