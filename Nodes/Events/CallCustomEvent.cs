using BepInNodeLoaderIl2Cpp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BepInNodeLoaderIl2Cpp.Nodes.Events;

public class CallCustomEvent : Node
{
    public string EventId { get; set; }
    public string EventName { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        ModsData.GetCustomEvent((string)args[0]).Execute();
    }
}
