﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Physics;

public class Raycast : Node
{
    public Vector3 Origin { get; set; }
    public Vector3 Direction { get; set; }
    public float MaxDistance { get; set; }

    [IsArgOut]
    public bool WasHit { get; set; }

    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.RaycastHit RaycastHit { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);

        var or = (Vector3)args[0];
        var dir = (Vector3)args[1];

        WasHit = UnityEngine.Physics.Raycast(new UnityEngine.Vector3(or.X, or.Y, or.Z), 
            new UnityEngine.Vector3(dir.X, dir.Y, dir.Z), out UnityEngine.RaycastHit hitInfo, (float)args[2]);
        if (WasHit)
            RaycastHit = hitInfo;
    }
}
