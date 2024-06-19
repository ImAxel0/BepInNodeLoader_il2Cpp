﻿using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Core.CoreNodes.Variables.Set;

public class ObjectSet : Node
{
    public object ValueIn { get; set; }

    [IsArgOut]
    public object ValueOut { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        ValueOut = (object)args[0];
        ModsData.ReplaceIdNodePair(ModsData.IdNodePair, this.Id, this.Id, this);
    }
}
