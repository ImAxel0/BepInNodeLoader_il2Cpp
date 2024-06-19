using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Transform;

public class GetRoot : Node
{
    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.Transform RootTr { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var tr = (UnityEngine.Transform)args[0];
        RootTr = tr.GetRoot();
    }
}
