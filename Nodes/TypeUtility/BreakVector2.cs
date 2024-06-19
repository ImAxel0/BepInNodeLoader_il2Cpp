﻿using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Numerics;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class BreakVector2 : Node
{
    [IsArgOut]
    public float X { get; set; }
    [IsArgOut]
    public float Y { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        var vec3 = (Vector2)args[0];
        X = vec3.X; Y = vec3.Y;
    }
}
