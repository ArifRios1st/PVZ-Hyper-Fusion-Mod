#if USE_TRANSLATE

using Il2Cpp;
using UnityEngine;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(Advanture_Btn))]
    public static class Advanture_Btn_Patch
    {
        [HarmonyPatch(nameof(Advanture_Btn.Start))]
        [HarmonyPostfix]
        private static void Start(Advanture_Btn __instance)
        {
            StringStore.TranslateTextTransform(__instance.transform, true);
            Transform parentTransform = __instance.transform.parent.transform;
            Transform levelTransform = parentTransform.Find("Levels");
            if (levelTransform != null)
            {
                Transform pageMiniGamesTransform = levelTransform.transform.Find("PageMiniGames");
                if (pageMiniGamesTransform != null)
                {
                    StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("BackToIndex"));
                    StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("Nextpage"));
                    StringStore.TranslateTextTransform(pageMiniGamesTransform.Find("LastPage"));
                }

                Transform pageUnlockChallengeTransform = levelTransform.transform.Find("PageUnlockChallenge");
                if (pageUnlockChallengeTransform != null)
                {
                    StringStore.TranslateTextTransform(pageUnlockChallengeTransform.Find("BackToIndex"));
                }

                Transform pageFlagChallengeTransform = levelTransform.transform.Find("PageFlagChallenge");
                if (pageFlagChallengeTransform != null)
                {
                    StringStore.TranslateTextTransform(pageFlagChallengeTransform.Find("BackToIndex"));
                }

                Transform pageTravelExperienceTransform = levelTransform.transform.Find("PageTravelExperience");
                if (pageTravelExperienceTransform != null)
                {
                    StringStore.TranslateTextTransform(pageTravelExperienceTransform.Find("BackToIndex"));
                }
            }

            StringStore.TranslateTextTransform(parentTransform.Find("CameraSize"));
            StringStore.TranslateTextTransform(parentTransform.Find("CanvasSize"));
        }
    }
}

#endif