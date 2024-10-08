#if USE_TRANSLATE
using Il2Cpp;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;


namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(DifficultyMgr))]
    public static class DifficultyMgr_Patch
    {
        [HarmonyPatch(nameof(DifficultyMgr.Update))]
        [HarmonyPostfix]
        private static void DifficultyMgr_Update(DifficultyMgr __instance)
        {
            __instance.t.text = StringStore.TranslateText(__instance.t.text);
            __instance.t.autoSizeTextContainer = false;
        }

    }
}
#endif