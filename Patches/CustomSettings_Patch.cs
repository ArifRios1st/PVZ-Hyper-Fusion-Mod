#if USE_TRANSLATE
using Il2Cpp;
using MelonLoader;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(CustomSettings))]
    public static class CustomSettings_Patch
    {
        [HarmonyPatch(nameof(CustomSettings.Awake))]
        [HarmonyPostfix]
        private static void Awake(CustomSettings __instance)
        {
            string oriText = __instance.textMesh.text;
            __instance.textMesh.text = StringStore.TranslateText(oriText);
        }

        [HarmonyPatch(nameof(CustomSettings.ChangeText))]
        [HarmonyPostfix]
        private static void ChangeText(CustomSettings __instance)
        {
            string oriText = __instance.textMesh.text;
            __instance.textMesh.text = StringStore.TranslateText(oriText);
        }
    }
}
#endif