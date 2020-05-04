using HarmonyLib;

using System;

using TaleWorlds.MountAndBlade;

namespace Aragas.MountAndBlade
{
	public class CivilizedSubModule : MBSubModuleBase
	{
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            try
            {
                var harmony = new Harmony("org.aragas.bannerlord.civilized");
                harmony.PatchAll(typeof(CivilizedSubModule).Assembly);
            }
            catch (Exception ex)
            {
                // TODO: Find a logger
            }
		}
    }
}