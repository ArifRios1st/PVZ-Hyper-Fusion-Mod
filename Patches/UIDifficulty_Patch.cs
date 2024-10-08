#if USE_TRANSLATE
using Il2Cpp;
using HarmonyLib;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(UIDifficulty))]
    public static class UIDifficulty_Patch
    {
        [HarmonyPatch(nameof(UIDifficulty.Update))]
        [HarmonyPostfix]
        private static void Update(UIDifficulty __instance)
        {
            __instance.t.text = string.Format("Difficulty: {0}", GameAPP.difficulty);
            __instance.t.autoSizeTextContainer = false;
        }
    }
}
#endif
