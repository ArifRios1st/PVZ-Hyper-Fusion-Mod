#if USE_TRANSLATE
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using UnityEngine;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(CustomSun))]
    public static class CustomSun_Patch
    {
        [HarmonyPatch(nameof(CustomSun.Awake))]
        [HarmonyPostfix]
        private static void Awake(CustomSun __instance)
        {
            if (__instance.inputField.gameObject.activeSelf)
            {
                string oriTextSun = __instance.inputField.m_Text;
                __instance.inputField.gameObject.SetActive(false);
                __instance.inputField.m_Text = StringStore.TranslateText(oriTextSun);
                __instance.inputField.m_OriginalText = StringStore.TranslateText(oriTextSun);
                __instance.inputField.gameObject.SetActive(true);
            }

            if (__instance.setFlags.gameObject.activeSelf)
            {
                string oriTextFlags = __instance.setFlags.m_Text;
                __instance.setFlags.gameObject.SetActive(false);
                __instance.setFlags.m_Text = StringStore.TranslateText(oriTextFlags);
                __instance.setFlags.m_OriginalText = StringStore.TranslateText(oriTextFlags);
                __instance.setFlags.gameObject.SetActive(true);
            }

            Transform lookZombieTransform = __instance.lookZombie.transform.GetChild(0).transform;
            if (lookZombieTransform != null)
            {
                TextMeshProUGUI lookZombieTMP = lookZombieTransform.GetComponent<TextMeshProUGUI>();
                if (lookZombieTMP != null)
                {
                    string lookZombieTMPOri = lookZombieTMP.text;
                    lookZombieTMP.text = StringStore.TranslateText(lookZombieTMPOri);
                }
            }
        }
    }
}
#endif