using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.Input;

public class GetKeyUp : Node
{
    public UnityEngine.KeyCode EnumValue { get; set; }

    [IsArgOut]
    public bool WasReleased { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        WasReleased = UnityEngine.Input.GetKeyUp((UnityEngine.KeyCode)args[0]);
    }
}
