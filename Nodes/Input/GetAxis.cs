using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.Input;

public class GetAxis : Node
{
    public string AxisName { get; set; }

    [IsArgOut]
    public float AxisValue { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        AxisValue = UnityEngine.Input.GetAxis((string)args[0]);
    }
}
