using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class IntToFloat : Node
{
    [IsArgOut]
    public float Converted { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Converted = (float)Convert.ToDouble((int)args[0]);
    }
}
