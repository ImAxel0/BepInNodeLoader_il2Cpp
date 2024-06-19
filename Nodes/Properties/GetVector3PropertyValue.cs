using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Properties;

public class GetVector3PropertyValue : Node
{
    [XmlIgnore]
    public UnityEngine.Component Component { get; set; }
    public string PropertyName { get; set; }

    [IsArgOut]
    public Vector3 Value { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (UnityEngine.Component)args[0];
        var property = com.GetIl2CppType().GetProperty((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic |
            Il2CppSystem.Reflection.BindingFlags.Instance | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static);
        var value = property.GetValue(com).Unbox<UnityEngine.Vector3>();
        Value = new Vector3(value.x, value.y, value.z);
    }
}
