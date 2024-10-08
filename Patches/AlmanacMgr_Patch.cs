#if USE_TRANSLATE
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;
using HarmonyLib;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(AlmanacMgr))]
    public static class AlmanacMgr_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch("Start")]
        private static void Start(AlmanacMgr __instance)
        {
            string basePatch = Path.Combine(Core.MOD_DIRECTORY, "PVZ_Hyper_Fusion");
            string path = Path.Combine(basePatch, "LawnStringsTranslate.json");

            string json;

            // Read the JSON content from the file or resources
            if (!File.Exists(path)) return;
            json = File.ReadAllText(path);

            TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
            TextMeshPro component2 = __instance.plantName.GetComponent<TextMeshPro>();
            TextMeshPro component3 = __instance.plantName.transform.GetChild(0).GetComponent<TextMeshPro>();
            TextMeshPro component4 = __instance.cost.GetComponent<TextMeshPro>();


            // Parse the JSON data
            AlmanacMgr.PlantData plantData = JsonUtility.FromJson<AlmanacMgr.PlantData>(json);

            // Find the plant by seedType and update the values
            foreach (AlmanacMgr.PlantInfo plantInfo in plantData.plants)
            {
                if (plantInfo.seedType == __instance.theSeedType)
                {
                    component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
                    component2.text = plantInfo.name;
                    component2.autoSizeTextContainer = true;
                    component3.text = plantInfo.name;
                    component3.autoSizeTextContainer = true;
                    component4.text = plantInfo.cost;
                    break;
                }
            }
        }
    }
}
#endif