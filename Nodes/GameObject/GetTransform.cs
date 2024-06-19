using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.GameObject;

public class GetTransform : Node
{
    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.Transform Transform { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var go = (UnityEngine.GameObject)args[0];
        Transform = go.transform;
    }
}
