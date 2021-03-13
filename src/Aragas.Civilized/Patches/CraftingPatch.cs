/*
using HarmonyLib;

using TaleWorlds.Core;

namespace Aragas.Civilized.Patches
{
    public class CraftingPatch
    {
        public static void Patch(Harmony harmony)
        {
            harmony.Patch(
                AccessTools.DeclaredMethod(typeof(Crafting), "GetItemFlags"),
                postfix: new HarmonyMethod(AccessTools.Method(typeof(CraftingPatch), nameof(Postfix))));
        }

        private static void Postfix(ref ItemFlags __result, WeaponDesign weaponDesign)
        {
            __result |= ItemFlags.Civilian;
        }
    }
}
*/