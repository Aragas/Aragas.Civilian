using System.Reflection;

using TaleWorlds.Core;

namespace Aragas.Core
{
    public class Utils
    {
        private static MethodInfo SetItemFlagsMethod { get; } = typeof(ItemObject).GetProperty("ItemFlags").SetMethod;

        public static void SetCivilian(ItemObject itemObject)
        {
            var flags = itemObject.ItemFlags | ItemFlags.Civilian;
            SetItemFlagsMethod.Invoke(itemObject, new object[] { flags });
        }
    }
}