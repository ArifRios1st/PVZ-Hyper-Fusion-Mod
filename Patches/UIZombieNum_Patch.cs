#if USE_TRANSLATE
using Il2Cpp;
using HarmonyLib;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(UIZombieNum))]
    public static class UIZombieNum_Patch
    {
        [HarmonyPatch(nameof(UIZombieNum.Update))]
        [HarmonyPostfix]
        private static void Update(UIZombieNum __instance)
        {
            __instance.t.text = string.Format("Zombies: {0}", Board.Instance.theCurrentNumOfZombieUncontroled);
        }
    }
}
#endif