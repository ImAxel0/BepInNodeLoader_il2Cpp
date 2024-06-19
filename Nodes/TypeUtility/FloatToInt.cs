using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.TypeUtility;

public class FloatToInt : Node
{
    [IsArgOut]
    public int Converted { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Converted = Convert.ToInt32((float)args[0]);
    }
}
