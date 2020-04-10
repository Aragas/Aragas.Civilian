using HarmonyLib;

using System;

using TaleWorlds.MountAndBlade;

namespace Aragas.MountAndBlade
{
	public class CivilizedSubModule : MBSubModuleBase
	{
		public CivilizedSubModule()
		{
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