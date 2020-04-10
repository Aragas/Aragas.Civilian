using HarmonyLib;

using System.Reflection;
using System.Xml;

using TaleWorlds.Core;

namespace Aragas.Core
{
    [HarmonyPatch(typeof(ItemObject))]
    [HarmonyPatch("Deserialize")]
    public class ItemObjectPatch
    {
        private static MethodInfo SetItemFlagsMethod { get; } =
            typeof(ItemObject).GetProperty("ItemFlags").SetMethod;

        public static void Postfix(ItemObject __instance, MBObjectManager objectManager, XmlNode node)
        {
            switch (node.Name)
            {
                case "CraftedItem":
                    SetCivilian(__instance);
                    break;
                case "Item":
                    if(!__instance.IsFood && !__instance.IsTradeGood && !__instance.IsAnimal)
                        SetCivilian(__instance);
                    break;
            }


        }

        private static void SetCivilian(ItemObject itemObject)
        {
            var flags = itemObject.ItemFlags | ItemFlags.Civilian;
            SetItemFlagsMethod.Invoke(itemObject, new object[] { flags });
        }
    }
}