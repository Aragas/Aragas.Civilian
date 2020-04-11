/*
using HarmonyLib;

using TaleWorlds.Core;

namespace Aragas.Core
{
    [HarmonyPatch(typeof(Crafting))]
    [HarmonyPatch("GetItemFlags")]
    public class CraftingPatch
    {
        public static void Postfix(ref ItemFlags __result, WeaponDesign weaponDesign)
        {
            __result |= ItemFlags.Civilian;
        }
    }
}
*/