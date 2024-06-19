using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

namespace BepInNodeLoaderIl2Cpp.Nodes.SceneManager;

public class GetSceneName : Node
{
    [XmlIgnore]
    public Scene Scene { get; set; }

    [IsArgOut]
    public string SceneName { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var scene = (Scene)args[0];
        SceneName = scene.name;
    }
}
