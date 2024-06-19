using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Rigidbody;

public class RbSetAngularDrag : Node
{
    [XmlIgnore]
    public UnityEngine.Rigidbody Rigidbody { get; set; }
    public float Drag { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var rb = (UnityEngine.Rigidbody)args[0];
        rb.angularDrag = (float)args[1];
    }
}
