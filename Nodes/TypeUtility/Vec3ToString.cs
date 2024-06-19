using System.Numerics;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;
using BepInNodeLoaderIl2Cpp.Core;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class Vec3ToString : Node
{
    [IsArgOut]
    public string Converted { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Converted = Convert.ToString((Vector3)args[0]);
    }
}
