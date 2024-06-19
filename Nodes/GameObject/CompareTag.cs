using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.GameObject;

public class CompareTag : Node
{
    [XmlIgnore]
    public UnityEngine.GameObject GameObject { get; set; }
    public string Tag { get; set; }

    [IsArgOut]
    public bool HasTag { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var go = (UnityEngine.GameObject)args[0];
        HasTag = go.CompareTag((string)args[1]);
    }
}
