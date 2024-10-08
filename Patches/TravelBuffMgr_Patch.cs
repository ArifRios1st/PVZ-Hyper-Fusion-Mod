#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(TravelBuffMgr))]
    public static class TravelBuffMgr_Patch
    {
        [HarmonyPatch(nameof(TravelBuffMgr.Awake))]
        [HarmonyPostfix]
        private static void Awake(TravelBuffMgr __instance)
        {
            __instance.text.text = AssetStore.StringStore.TranslateText(__instance.text.text);
            __instance.text2.text = AssetStore.StringStore.TranslateText(__instance.text2.text);
        }

        [HarmonyPatch(nameof(TravelBuffMgr.OnEnable))]
        [HarmonyPostfix]
        private static void OnEnable(TravelBuffMgr __instance)
        {
            __instance.text.text = AssetStore.StringStore.TranslateText(__instance.text.text);
            __instance.text2.text = AssetStore.StringStore.TranslateText(__instance.text2.text);
        }

        [HarmonyPatch(nameof(TravelBuffMgr.ShowText), new Type[] { typeof(int), typeof(int) })]
        [HarmonyPostfix]
        private static void ShowText(TravelBuffMgr __instance)
        {
            __instance.text.text = AssetStore.StringStore.TranslateText(__instance.text.text);
            __instance.text2.text = AssetStore.StringStore.TranslateText(__instance.text2.text);
        }
    }
}
#endif