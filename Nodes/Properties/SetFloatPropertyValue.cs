using System.Xml.Serialization;
using UnityEngine;
using System.Collections.Generic;
using BepInNodeLoaderIl2Cpp.Core;

namespace BepInNodeLoaderIl2Cpp.Generics;

public class SetFloatPropertyValue : Node
{
    [XmlIgnore]
    public Component Component { get; set; }
    public string PropertyName { get; set; }
    public float Value { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (Component)args[0];
        var property = com.GetIl2CppType().GetProperty((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic |
            Il2CppSystem.Reflection.BindingFlags.Instance | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static);
        property.SetValue(com, (float)args[2]);
    }
}
