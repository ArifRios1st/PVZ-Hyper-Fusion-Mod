#if USE_TRANSLATE
using HarmonyLib;
using Il2CppTMPro;
using PVZ_Hyper_Fusion.AssetStore;
using System.Reflection;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(TextMeshPro))]
    public static class TextMeshPro_Patch
    {
        [HarmonyPatch(nameof(TextMeshPro.OnEnable))]
        [HarmonyPostfix]
        private static void OnEnable(TextMeshPro __instance)
        {
            // Check if the text property is set and translate it
            if (!string.IsNullOrEmpty(__instance.text))
            {
                __instance.text = StringStore.TranslateText(__instance.text);
                __instance.autoSizeTextContainer = true;
            }
        }  
    }
}
#endif
