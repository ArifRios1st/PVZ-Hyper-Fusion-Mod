#if USE_TRANSLATE
using HarmonyLib;
using Il2CppTMPro;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(TextMeshProUGUI))]
    public static class TextMeshProUGUI_Patch
    {
        [HarmonyPatch(nameof(TextMeshProUGUI.OnEnable))]
        [HarmonyPostfix]
        private static void OnEnable(TextMeshProUGUI __instance)
        {
            // Check if the text property is set and translate it
            if (!string.IsNullOrEmpty(__instance.text))
            {
                __instance.autoSizeTextContainer = false;
                __instance.text = StringStore.TranslateText(__instance.text);
            }
        }

    }
}
#endif