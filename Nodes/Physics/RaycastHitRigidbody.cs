﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace BepInNodeLoaderIl2Cpp.Nodes.Physics;

public class RaycastHitRigidbody : Node
{
    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.Rigidbody Rigidbody { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var hitInfo = (RaycastHit)args[0];
        Rigidbody = hitInfo.rigidbody;
    }
}
