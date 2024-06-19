using System.Numerics;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using BepInNodeLoaderIl2Cpp.Core;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class MakeVector3 : Node
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    [IsArgOut]
    public Vector3 xyz { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        xyz = new Vector3((float)args[0], (float)args[1], (float)args[2]);
    }
}
