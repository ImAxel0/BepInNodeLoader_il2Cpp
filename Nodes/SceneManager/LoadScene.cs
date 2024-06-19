using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

namespace BepInNodeLoaderIl2Cpp.Nodes.SceneManager;

public class LoadScene : Node
{
    public string SceneName { get; set; }

    [XmlIgnore]
    public LoadSceneMode EnumValue { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        UnityEngine.SceneManagement.SceneManager.LoadScene((string)args[0], (LoadSceneMode)args[1]);
    }
}
