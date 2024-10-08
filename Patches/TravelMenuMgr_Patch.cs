#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(TravelMenuMgr))]
    public static class TravelMenuMgr_Patch
    {
        [HarmonyPatch(nameof(TravelMenuMgr.Start))]
        [HarmonyPostfix]
        private static void Start(TravelMenuMgr __instance)
        {
            foreach(TextMeshProUGUI text in __instance.textMesh)
            {
                text.text = AssetStore.StringStore.TranslateText(text.text);
            }
            foreach(TextMeshProUGUI text in __instance.textMeshShadow)
            {
                text.text = AssetStore.StringStore.TranslateText(text.text);
            }
        }
        [HarmonyPatch(nameof(TravelMenuMgr.SetText))]
        [HarmonyPostfix]
        private static void SetText(TravelMenuMgr __instance)
        {
            foreach(TextMeshProUGUI text in __instance.textMesh)
            {
                text.text = AssetStore.StringStore.TranslateText(text.text);
            }
            foreach(TextMeshProUGUI text in __instance.textMeshShadow)
            {
                text.text = AssetStore.StringStore.TranslateText(text.text);
            }
        }
    }
}
#endif