﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class GetWorldPosition : Node
{
    [IsArgOut]
    public Vector3 Position { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        Position = new Vector3(tr.position.x, tr.position.y, tr.position.z);
    }
}
