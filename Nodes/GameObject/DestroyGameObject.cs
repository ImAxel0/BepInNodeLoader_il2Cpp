using BepInNodeLoaderIl2Cpp.Core;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.GameObject;

public class DestroyGameObject : Node
{
    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        UnityEngine.GameObject.Destroy((UnityEngine.GameObject)args[0]);
    }
}
