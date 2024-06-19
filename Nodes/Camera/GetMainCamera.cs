using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BepInNodeLoaderIl2Cpp.Nodes.Camera;

public class GetMainCamera : Node
{
    [XmlIgnore]
    UnityEngine.Camera MainCamera { get; set; }

    [XmlIgnore]
    UnityEngine.Transform CameraTr { get; set; }

    public override void Execute()
    {
        MainCamera = UnityEngine.Camera.main;
        CameraTr = UnityEngine.Camera.main.transform;
    }
}
