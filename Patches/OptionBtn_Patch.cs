#if USE_TRANSLATE
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(OptionBtn))]
    public static class OptionBtn_Patch
    {
        [HarmonyPatch(nameof(OptionBtn.Awake))]
        [HarmonyPostfix]
        private static void Awake(OptionBtn __instance)
        {
            Transform text_1Transform = __instance.transform.GetChild(0)?.transform;
            if (text_1Transform != null)
            {
                TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();
                text_1.text = StringStore.TranslateText(text_1.text);
                text_1.autoSizeTextContainer = false;

            }

            Transform textTransform = __instance.transform.GetChild(1)?.transform;
            if (textTransform != null)
            {
                TextMeshProUGUI text = textTransform.GetComponent<TextMeshProUGUI>();
                text.text = StringStore.TranslateText(text.text);
                text.autoSizeTextContainer = false;

            }

            Transform text2Transform = __instance.transform.GetChild(2)?.transform;
            if (text2Transform != null)
            {
                TextMeshProUGUI text2 = text2Transform.GetComponent<TextMeshProUGUI>();
                text2.text = StringStore.TranslateText(text2.text);
                text2.autoSizeTextContainer = true;

            }
        }

        [HarmonyPatch(nameof(OptionBtn.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton(OptionBtn __instance)
        {
            Transform text_1Transform = __instance.transform.GetChild(0)?.transform;
            if (text_1Transform != null)
            {
                TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();
                text_1.text = StringStore.TranslateText(text_1.text);
                text_1.autoSizeTextContainer = false;

            }

            Transform textTransform = __instance.transform.GetChild(1)?.transform;
            if (textTransform != null)
            {
                TextMeshProUGUI text = textTransform.GetComponent<TextMeshProUGUI>();
                text.text = StringStore.TranslateText(text.text);
                text.autoSizeTextContainer = false;

            }

            Transform text2Transform = __instance.transform.GetChild(2)?.transform;
            if (text2Transform != null)
            {
                TextMeshProUGUI text2 = text2Transform.GetComponent<TextMeshProUGUI>();
                text2.text = StringStore.TranslateText(text2.text);
                text2.autoSizeTextContainer = true;

            }
        }

    }
}
#endif