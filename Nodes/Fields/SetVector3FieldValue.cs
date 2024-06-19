using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Fields;

public class SetVector3FieldValue : Node
{
    [XmlIgnore]
    public UnityEngine.Component Component { get; set; }
    public string FieldName { get; set; }
    public Vector3 Value { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (UnityEngine.Component)args[0];
        var field = com.GetIl2CppType().GetField((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic |
            Il2CppSystem.Reflection.BindingFlags.Instance | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static);
        var value = (Vector3)args[2];
        BLogger.BLog.LogWarning("SetVector3FieldValue isn't supported");
        //field.SetValue(com, new UnityEngine.Vector3(value.X, value.Y, value.Z));
    }
}
