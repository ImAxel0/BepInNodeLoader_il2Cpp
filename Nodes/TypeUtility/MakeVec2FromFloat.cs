using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class MakeVec2FromFloat : Node
{
    public float Value { get; set; }

    [IsArgOut]
    public Vector2 xyz { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        xyz = new Vector2((float)args[0], (float)args[0]);
    }
}
