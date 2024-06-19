﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.Rigidbody;

public class RbGetCenterOfMass : Node
{
    [IsArgOut]
    public Vector3 Center { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var rb = (UnityEngine.Rigidbody)args[0];
        var v3 = new Vector3(rb.centerOfMass.x, rb.centerOfMass.y, rb.centerOfMass.z);
        Center = v3;
    }
}
