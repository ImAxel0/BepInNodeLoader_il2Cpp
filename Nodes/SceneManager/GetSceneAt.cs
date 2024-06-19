using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

namespace BepInNodeLoaderIl2Cpp.Nodes.SceneManager;

public class GetSceneAt : Node
{
    public int Index { get; set; }

    [XmlIgnore]
    [IsArgOut]
    public Scene Scene { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Scene = UnityEngine.SceneManagement.SceneManager.GetSceneAt((int)args[0]);
    }
}
