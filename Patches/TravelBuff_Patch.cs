#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(TravelBuff))]
    public static class TravelBuff_Patch
    {
        [HarmonyPatch(nameof(TravelBuff.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton()
        {
            TravelBuffMgr.Instance.text.text = AssetStore.StringStore.TranslateText(TravelBuffMgr.Instance.text.text);
            TravelBuffMgr.Instance.text2.text = AssetStore.StringStore.TranslateText(TravelBuffMgr.Instance.text2.text);
        }
    }
}
#endif