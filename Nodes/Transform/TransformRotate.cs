﻿using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class TransformRotate : Node
{
    [XmlIgnore]
    public UnityEngine.Transform Transform { get; set; }
    public Vector3 Rotation { get; set; }
    public UnityEngine.Space EnumValue { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        var rot = (Vector3)args[1];
        tr.Rotate(new UnityEngine.Vector3(rot.X, rot.Y, rot.Z), (UnityEngine.Space)args[2]);
    }
}
