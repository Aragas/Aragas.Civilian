using Aragas.Civilized.Patches;

using HarmonyLib;

using TaleWorlds.MountAndBlade;

namespace Aragas.Civilized
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            var harmony = new Harmony("org.aragas.bannerlord.civilized");
            ItemObjectPatch.Patch(harmony);
        }
    }
}