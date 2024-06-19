using BepInNodeLoaderIl2Cpp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UnityEngine;

namespace BepInNodeLoaderIl2Cpp.Nodes.Methods;

public class CallMethod : Node
{
    [XmlIgnore]
    public Component Component { get; set; }

    public string MethodName { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var com = (Component)args[0];
        com.GetIl2CppType().GetMethod((string)args[1], Il2CppSystem.Reflection.BindingFlags.NonPublic | Il2CppSystem.Reflection.BindingFlags.Instance
            | Il2CppSystem.Reflection.BindingFlags.Public | Il2CppSystem.Reflection.BindingFlags.Static).Invoke(com, null);
    }
}
