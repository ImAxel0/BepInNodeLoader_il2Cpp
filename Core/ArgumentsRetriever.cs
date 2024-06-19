using BepInNodeLoaderIl2Cpp.CustomAttributes;
using System.Collections.Generic;
using System.Linq;

namespace BepInNodeLoaderIl2Cpp.Core;

public class ArgumentsRetriever
{
    public static Node GetNodeById(string id)
    {
        if (ModsData.IdNodePair.TryGetValue(id, out Node node))
        {
            return node;
        }
        return null;
    }

    public static List<object> GetArgumentsOf(Node thisNode)
    {
        List<object> args = new();

        int argIdx = 0;
        thisNode.ArgsIn.ForEach(argIn => {

            if (!argIn.HasConnection)
            {
                args.Add(thisNode.GetType().GetProperties().Where(p => p.DeclaringType == thisNode.GetType()).ElementAt(argIdx).GetValue(thisNode));
            }
            else
            {
                Node node = GetNodeById(argIn.ReceiveFrom);
                var prop = node.GetType().GetProperties().Where(p => p.DeclaringType == node.GetType()
                && p.GetCustomAttributes(typeof(IsArgOut), false).Any());

                args.Add(prop.ElementAt(argIn.ReceiveFromIndex).GetValue(node));
            }
            argIdx++;
        });

        return args;
    }
}
