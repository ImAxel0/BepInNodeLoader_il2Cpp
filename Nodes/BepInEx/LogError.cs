using BepInNodeLoaderIl2Cpp.Core;
using BepInNodeLoaderIl2Cpp.Utilities;
using System.Collections.Generic;

namespace BepInNodeLoaderIl2Cpp.Nodes.BepInEx;

public class LogError : Node
{
    public string Message { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        BLogger.BLog.LogError((string)args[0]);
    }
}
