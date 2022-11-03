using HarmonyLib;
using HarmonyLib.BUTR.Extensions;

using TaleWorlds.Core;

namespace Aragas.Civilized
{
    public class Utils
    {
        private delegate void SetItemFlagsDelegate(ItemObject instance, ItemFlags itemFlags);
        private static readonly SetItemFlagsDelegate? SetItemFlags =
            AccessTools2.GetPropertySetterDelegate<SetItemFlagsDelegate>(typeof(ItemObject), "ItemFlags");

        public static void SetCivilian(ref ItemObject itemObject)
        {
            if (SetItemFlags is not null)
            {
                SetItemFlags(itemObject, itemObject.ItemFlags | ItemFlags.Civilian);
            }
        }
    }
}