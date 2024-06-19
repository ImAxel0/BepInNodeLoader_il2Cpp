using BepInNodeLoaderIl2Cpp.CustomAttributes;

namespace BepInNodeLoaderIl2Cpp.Nodes.Input;

public class AnyKey : Node
{
    [IsArgOut]
    public bool Result { get; set; }

    public override void Execute()
    {
        Result = UnityEngine.Input.anyKey;
    }
}
