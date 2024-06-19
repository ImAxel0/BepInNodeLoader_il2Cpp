using BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Get;

public class ComponentGet : Node
{
    [IsArgOut]
    [XmlIgnore]
    public UnityEngine.Component Value { get; set; }

    public override void Execute()
    {
        var setNode = (ComponentSet)ModsData.GetNodeById(this.Id);
        Value = setNode.ValueOut;
    }
}
