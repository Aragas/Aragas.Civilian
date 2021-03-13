using HarmonyLib;

using System.Xml;

using TaleWorlds.Core;

namespace Aragas.Civilized.Patches
{
    public class ItemObjectPatch
    {
        public static void Patch(Harmony harmony)
        {
            harmony.Patch(
                AccessTools.DeclaredMethod(typeof(ItemObject), "Deserialize"),
                postfix: new HarmonyMethod(AccessTools.Method(typeof(ItemObjectPatch), nameof(Postfix))));

#if CRAFTED
            harmony.Patch(
                AccessTools.DeclaredMethod(typeof(ItemObject), "InitCraftedItemObject"),
                postfix: new HarmonyMethod(AccessTools.Method(typeof(ItemObjectPatch), nameof(Postfix2))));
#endif
        }

        private static void Postfix(ItemObject __instance, XmlNode node)
        {
            switch (node.Name)
            {
                case "CraftedItem":
                    Utils.SetCivilian(__instance);
                    break;
                case "Item":
                    if(!__instance.IsFood && !__instance.IsTradeGood && !__instance.IsAnimal)
                        Utils.SetCivilian(__instance);
                    break;
            }
        }

        private static void Postfix2(ref ItemObject itemObject)
        {
            Utils.SetCivilian(itemObject);
        }
    }
}