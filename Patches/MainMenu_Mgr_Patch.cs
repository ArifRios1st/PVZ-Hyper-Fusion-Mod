#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(MainMenu_Mgr))]
    public class MainMenu_Mgr_Patch
    {
        [HarmonyPatch(nameof(MainMenu_Mgr.FixedUpdate))]
        [HarmonyPostfix]
        private static void FixedUpdate(MainMenu_Mgr __instance)
        {
            __instance.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "NaKune";
        }
    }
}
#endif