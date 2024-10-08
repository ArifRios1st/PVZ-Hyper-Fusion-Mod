#if USE_TRANSLATE
using Il2Cpp;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(PauseMenu_Btn))]
    public static class PauseMenu_Btn_Patch
    {
        [HarmonyPatch(nameof(PauseMenu_Btn.Start))]
        [HarmonyPostfix]
        private static void Start(PauseMenu_Btn __instance)
        {
            StringStore.TranslateTextTransform(__instance.transform);
        }
    }

}
#endif