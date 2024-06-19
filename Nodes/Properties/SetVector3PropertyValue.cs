using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Properties;

public class SetVector3PropertyValue : Node
{
    [XmlIgnore]
    public UnityEngine.Component Component { get; set; }
    public string PropertyName { get; set; }
    public float Value { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (UnityEngine.Component)args[0];
        var property = com.GetIl2CppType().GetProperty((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic |
            Il2CppSystem.Reflection.BindingFlags.Instance | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static);
        var value = (Vector3)args[2];
        BLogger.BLog.LogWarning("SetVector3PropertyValue isn't supported");
        //property.SetValue(com, new UnityEngine.Vector3(value.X, value.Y, value.Z));
    }
}
