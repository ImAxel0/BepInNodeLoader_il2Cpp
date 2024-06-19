using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.Math;

public class Divide : Node
{
    public float First { get; set; }
    public float Second { get; set; }

    [IsArgOut]
    public float Result { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Result = (float)args[0] / (float)args[1];
    }
}
