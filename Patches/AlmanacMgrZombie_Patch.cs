#if USE_TRANSLATE
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;
using static Il2Cpp.AlmanacMgr;

namespace PVZ_Hyper_Fusion.Patches
{
    [HarmonyPatch(typeof(AlmanacMgrZombie))]
    public static class AlmanacMgrZombie_Patch
    {
        [HarmonyPatch(nameof(AlmanacMgrZombie.InitNameAndInfoFromJson))]
        [HarmonyPrefix]
        private static bool InitNameAndInfoFromJson(AlmanacMgrZombie __instance) 
        {
            string basePatch = Path.Combine(Core.MOD_DIRECTORY, "PVZ_Hyper_Fusion");
            string path = Path.Combine(basePatch, "ZombieStringsTranslate.json");

            // Read the JSON content from the file or resources
            if (!File.Exists(path)) return true;

            string json;
            json = File.ReadAllText(path);

            TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
            TextMeshPro component2 = __instance.zombieName.GetComponent<TextMeshPro>();
            TextMeshPro component3 = __instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>();

            // Parse the JSON data
            AlmanacMgrZombie.ZombieAlmanacData zombieData = JsonUtility.FromJson<AlmanacMgrZombie.ZombieAlmanacData>(json);
            foreach (AlmanacMgrZombie.ZombieInfo zombieInfo in zombieData.zombies)
            {
                if (zombieInfo.theZombieType == __instance.theZombieType)
                {
                    component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
                    component2.text = zombieInfo.name;
                    component2.autoSizeTextContainer = true;
                    component3.text = zombieInfo.name;
                    component3.autoSizeTextContainer = true;
                    break;
                }
            }

            return false;
        }
    }
}
#endif