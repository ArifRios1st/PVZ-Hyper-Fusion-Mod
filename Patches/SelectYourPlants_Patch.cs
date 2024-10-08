#if USE_TRANSLATE
using Il2Cpp;
using MelonLoader;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(SelectYourPlants))]
    public static class SelectYourPlants_Patch
    {
        [HarmonyPatch(nameof(SelectYourPlants.Awake))]
        [HarmonyPostfix]
        private static void Awake(SelectYourPlants __instance)
        {
            string oriText = __instance.TextMeshProUGUI.text;
            __instance.TextMeshProUGUI.text = StringStore.TranslateText(oriText);
            __instance.TextMeshProUGUI.autoSizeTextContainer = true;

            string oriText2 = __instance.TextMeshProUGUI2.text;
            __instance.TextMeshProUGUI2.text = StringStore.TranslateText(oriText2);
            __instance.TextMeshProUGUI2.autoSizeTextContainer = true;
        }
    }
}
#endif