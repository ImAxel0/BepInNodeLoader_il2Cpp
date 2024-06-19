using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BepInNodeLoaderIl2Cpp.Nodes.Math;

public class DivideVec3ByNumber : Node
{
    public Vector3 First { get; set; }
    public float Second { get; set; }

    [IsArgOut]
    public Vector3 Result { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        Result = (Vector3)args[0] / (float)args[1];
    }
}
