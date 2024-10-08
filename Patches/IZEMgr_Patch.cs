using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(IZEMgr))]
    public static class IZEMgr_Patch
    {
        [HarmonyPatch(nameof(IZEMgr.Start))]
        [HarmonyPostfix]
        public static void Start(IZEMgr __instance)
        {
            TextMeshProUGUI[] array = new TextMeshProUGUI[]
            {
                    __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
                    __instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
            };
            for (int i = 0; i < array.Length; i++)
            {
                array[i].text = StringStore.TranslateText(array[i].text).Replace("\n", " ");
            }
        }
    }
}
