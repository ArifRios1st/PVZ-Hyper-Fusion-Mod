#if USE_TRANSLATE
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(EndlessMgr))]
    public static class EndlessMgr_Patch
    {
        [HarmonyPatch(nameof(EndlessMgr.Awake))]
        [HarmonyPostfix]
        private static void Awake(EndlessMgr __instance)
        {
            Transform textTransform = __instance.transform.GetChild(2);
            if (textTransform != null && textTransform.gameObject.activeSelf)
            {
                TextMeshProUGUI textTMP = textTransform.GetComponent<TextMeshProUGUI>();
                if (textTMP != null)
                {
                    textTMP.text = StringStore.TranslateText(textTMP.text);
                }
            }

        }
    }
}
#endif