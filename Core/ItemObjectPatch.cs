#define CRAFTED
using HarmonyLib;

using System.Xml;

using TaleWorlds.Core;

namespace Aragas.Core
{
    [HarmonyPatch(typeof(ItemObject))]
    [HarmonyPatch("Deserialize")]
    public class ItemObjectPatch1
    {
        public static void Postfix(ItemObject __instance, XmlNode node)
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
    }

#if CRAFTED
    [HarmonyPatch(typeof(ItemObject))]
    [HarmonyPatch("InitCraftedItemObject")]
    public class ItemObjectPatch2
    {
        public static void Postfix(ref ItemObject itemObject)
        {
            Utils.SetCivilian(itemObject);
        }
    }
#endif
}