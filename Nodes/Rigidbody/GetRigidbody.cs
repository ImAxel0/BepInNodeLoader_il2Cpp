﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Rigidbody;

public class GetRigidbody : Node
{
    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.Rigidbody rb { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        rb = tr.GetComponent<UnityEngine.Rigidbody>();
    }
}
