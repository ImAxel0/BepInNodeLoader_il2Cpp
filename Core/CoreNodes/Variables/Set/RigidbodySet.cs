﻿using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;

public class RigidbodySet : Node
{
    [XmlIgnore]
    public UnityEngine.Rigidbody ValueIn { get; set; }

    [IsArgOut]
    [XmlIgnore]
    public UnityEngine.Rigidbody ValueOut { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        ValueOut = (UnityEngine.Rigidbody)args[0];
        ModsData.ReplaceIdNodePair(ModsData.IdNodePair, this.Id, this.Id, this);
    }
}
