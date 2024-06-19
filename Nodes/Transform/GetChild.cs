﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class GetChild : Node
{
    [XmlIgnore]
    public UnityEngine.Transform Transform { get; set; }
    public int Index { get; set; }

    [IsArgOut]
    [XmlIgnore]
    public UnityEngine.Transform ChildTr { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        ChildTr = tr.GetChild((int)args[1]);
    }
}
