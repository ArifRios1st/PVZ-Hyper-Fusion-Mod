#if USE_TRANSLATE
using Il2Cpp;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(InGameText))]
    public static class InGameText_Patch
    {
        [HarmonyPatch(nameof(InGameText.EnableText), new Type[] { typeof(string), typeof(float) })]
        [HarmonyPrefix]
        private static void EnableText(InGameText __instance, ref string text)
        {
            text = StringStore.TranslateText(text,true);
        }

        [HarmonyPatch(nameof(InGameText.EnableText), new Type[] { typeof(string), typeof(float) })]
        [HarmonyPostfix]
        private static void EnableText(InGameText __instance)
        {
            __instance.t.text = StringStore.TranslateText(__instance.t.text, true);
        }
    }
}
#endif