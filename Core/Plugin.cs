using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInNodeLoaderIl2Cpp.Core.NodeActions;
using BepInNodeLoaderIl2Cpp.Core.Runtime;
using BepInNodeLoaderIl2Cpp.Utilities;

namespace BepInNodeLoaderIl2Cpp.Core;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public override void Load()
    {
        Utilities.BLogger.BLog = BepInEx.Logging.Logger.CreateLogSource("BepInNodeLogger");
        PipeManager.WaitForConnection();
        ModsData.SetupMods();
        ModsData.LoadMods();

        // execute all OnLoad nodes
        ModsData.AllModsData.ForEach(mod =>
        {
            mod.OnLoad.ForEach(node =>
            {
                node.Execute();
            });
        });

        // injecting MonoBehaviours
        this.AddComponent<OnUpdate>();
        BLogger.BLog.LogInfo("OnUpdate Injected!");
        this.AddComponent<OnFixedUpdate>();
        BLogger.BLog.LogInfo("OnFixedUpdate Injected!");
    }
}
