#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(InGameBtn))]
    public static class InGameBtn_Patch
    {
        [HarmonyPatch(nameof(InGameBtn.Update))]
        [HarmonyPostfix]
        private static void Update(InGameBtn __instance)
        {
            Transform sceneText = __instance.transform.FindChild("SceneText");
            if(sceneText != null)
            {
                TextMeshProUGUI sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();
                if(sceneTextTMP != null)
                {
                    sceneTextTMP.text = AssetStore.StringStore.TranslateText(sceneTextTMP.text);
                }
                Transform sceneTextShadow = sceneText.transform.FindChild("SceneText");
                if(sceneTextShadow != null)
                {
                    TextMeshProUGUI sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();
                    if (sceneTextShadowTMP != null)
                    {
                        sceneTextShadowTMP.text = AssetStore.StringStore.TranslateText(sceneTextShadowTMP.text);
                    }
                }
            }
        }
    }
}
#endif