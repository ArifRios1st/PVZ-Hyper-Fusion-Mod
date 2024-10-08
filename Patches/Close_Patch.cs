#if USE_TRANSLATE
using UnityEngine;
using HarmonyLib;
using Il2CppTMPro;
using Il2Cpp;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(Close))]
    public static class Close_Patch
    {
        [HarmonyPatch(nameof(Close.Start))]
        [HarmonyPostfix]
        private static void Close_Start(Close __instance)
        {
            Il2CppTMPro.TextMeshPro closeText = __instance.transform.GetChild(0).GetComponent<Il2CppTMPro.TextMeshPro>();
            closeText.text = StringStore.TranslateText(closeText.text);
            closeText.autoSizeTextContainer = true;

            Transform AlmanacTransform = __instance.transform.parent.transform;

            Transform nameTransform = AlmanacTransform.Find("Name");
            if (nameTransform != null)
            {
                Il2CppTMPro.TextMeshPro nameTMP = nameTransform.transform.GetComponent<Il2CppTMPro.TextMeshPro>();
                if (nameTMP)
                {
                    nameTMP.text = StringStore.TranslateText(nameTMP.text);
                    nameTMP.autoSizeTextContainer = true;
                }

                Transform nameShadowTransform = nameTransform.Find("NameShadow");
                if (nameShadowTransform)
                {
                    Il2CppTMPro.TextMeshPro nameShadowTMP = nameShadowTransform.transform.GetComponent<Il2CppTMPro.TextMeshPro>();
                    if (nameShadowTMP)
                    {
                        nameShadowTMP.text = StringStore.TranslateText(nameShadowTMP.text);
                        nameShadowTMP.autoSizeTextContainer = true;
                    }
                }
            }

            StringStore.TranslateTextTransform(AlmanacTransform.Find("Back"), true);
            StringStore.TranslateTextTransform(AlmanacTransform.Find("NextPage"));
            StringStore.TranslateTextTransform(AlmanacTransform.Find("LastPage"));

        }
    }
}
#endif