﻿using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class SetLocalPosition : Node
{
    [XmlIgnore]
    public UnityEngine.Transform Transform { get; set; }

    public Vector3 xyz { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        var pos = (Vector3)args[1];
        tr.localPosition = new UnityEngine.Vector3(pos.X, pos.Y, pos.Z);
    }
}
