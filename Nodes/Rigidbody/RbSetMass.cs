using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Rigidbody;

public class RbSetMass : Node
{
    [XmlIgnore]
    public UnityEngine.Rigidbody Rigidbody { get; set; }
    public float Mass { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var rb = (UnityEngine.Rigidbody)args[0];
        rb.mass = (float)args[1];
    }
}
