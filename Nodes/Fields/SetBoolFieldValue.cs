using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Fields;

public class SetBoolFieldValue : Node
{
    [XmlIgnore]
    public UnityEngine.Component Component { get; set; }
    public string FieldName { get; set; }
    public bool Value { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (UnityEngine.Component)args[0];
        var field = com.GetIl2CppType().GetField((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic |
            Il2CppSystem.Reflection.BindingFlags.Instance | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static);
        field.SetValue(com, (bool)args[2]);
    }
}
