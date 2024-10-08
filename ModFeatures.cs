#if USE_MOD
using Il2Cpp;
using System.Text;
using UnityEngine;
using HarmonyLib;
using PVZ_Hyper_Fusion.AssetStore;

namespace PVZ_Hyper_Fusion
{
    public static class ModFeatures
    {
        public enum ModType
        {
            UnlimitedSun,
            NoCooldown,
            NoTakeDamagePlant,
            ColumnPlant,
            DeveloperMode,
            ReloadStrings,
            Help,
        }

        private class ModFeature
        {
            public string Name { get; private set; }
            public ModType ModType { get; private set; }
            public KeyCode KeyCode { get; private set; }
            public bool IsActive { get; set; }

            public ModFeature(string Name, ModType ModType, KeyCode KeyCode, bool defaultValue = false)
            {
                this.Name = Name;
                this.ModType = ModType;
                this.KeyCode = KeyCode;
                this.IsActive = defaultValue;
            }

            public void ToggleFeature()
            {
#if USE_TRANSLATE
                if (this.ModType == ModType.ReloadStrings)
                {
                    StringStore.Reload();
                    Core.ShowToast("Translation String Reloaded!");
                    return;
                }
#endif
                IsActive = !IsActive;
                if (this.ModType == ModType.Help)
                    return;


                Core.ShowToast(string.Format("{0} [{1}]", this.Name, IsActive ? "ON" : "OFF"));
            }

            public override string ToString()
            {
                if(this.ModType == ModType.ReloadStrings || this.ModType == ModType.Help)
                    return string.Format("[{0}]{1}", this.KeyCode.ToString(), this.Name);

                return string.Format("[{0}]{1} [{2}]", this.KeyCode.ToString(), this.Name, IsActive ? "ON" : "OFF");
            }
        }

        private static Dictionary<ModType, ModFeature> featureLists = new Dictionary<ModType, ModFeature>()
        {
            {ModType.UnlimitedSun,new ModFeature("Unlimited Sun",ModType.UnlimitedSun,KeyCode.F1)},
            {ModType.NoCooldown,new ModFeature("No Cooldown",ModType.NoCooldown,KeyCode.F2)},
            {ModType.NoTakeDamagePlant,new ModFeature("No Take Damage",ModType.NoTakeDamagePlant,KeyCode.F3)},
            {ModType.ColumnPlant,new ModFeature("Column Plant",ModType.ColumnPlant,KeyCode.F4)},
            {ModType.DeveloperMode,new ModFeature("Developer Mode",ModType.DeveloperMode,KeyCode.F5)},
#if USE_TRANSLATE
            {ModType.ReloadStrings,new ModFeature("Reload Translation String",ModType.ReloadStrings,KeyCode.Home, true)},
#endif
            {ModType.Help,new ModFeature("Feature Lists",ModType.Help,KeyCode.Insert, false)},
        };

        public static string GetFeatures()
        {
            StringBuilder status = new StringBuilder();
            status.AppendLine("Features: ");
            foreach (var feature in featureLists.Values)
            {
                status.AppendLine(feature.ToString());
            }
            return status.ToString();
        }

        public static void ToggleFeature(ModType ModType)
        {
            if (!featureLists.ContainsKey(ModType))
                return;

            featureLists[ModType].ToggleFeature();
        }

        public static bool GetActive(ModType ModType)
        {
            if (!featureLists.ContainsKey(ModType))
                return false;

            return featureLists[ModType].IsActive;
        }

        public static void SetActive(ModType ModType, bool value)
        {
            if (!featureLists.ContainsKey(ModType))
                return;

            featureLists[ModType].IsActive = value;
        }

        public static void OnLateUpdate()
        {
            foreach (var (type, feature) in featureLists)
            {
                if (feature.KeyCode != KeyCode.None && Enum.IsDefined(typeof(KeyCode), feature.KeyCode))
                {
                    if (Input.GetKeyDown(feature.KeyCode))
                    {
                        feature.ToggleFeature();
                    }
                }
            }
        }

        private static class PatchClasses
        {
            [HarmonyPatch(typeof(CardUI))]
            public static class CardUI_Patch
            {
                [HarmonyPostfix]
                [HarmonyPatch("Update")]
                private static void Update(CardUI __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoCooldown))
                    {
                        __instance.CD = __instance.fullCD;
                        __instance.isAvailable = true;

                    }
                }
            }

            [HarmonyPatch(typeof(GloveMgr))]
            public static class GloveMgr_Patch
            {
                [HarmonyPrefix]
                [HarmonyPatch("CDUpdate")]
                private static void CDUpdate(GloveMgr __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoCooldown))
                    {
                        __instance.CD = __instance.fullCD;
                        __instance.avaliable = true;
                    }
                }
            }

            [HarmonyPatch(typeof(HammerMgr))]
            public static class HammerMgr_Patch
            {
                [HarmonyPrefix]
                [HarmonyPatch("CDUpdate")]
                private static void CDUpdate(HammerMgr __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoCooldown))
                    {
                        __instance.CD = __instance.fullCD;
                        __instance.avaliable = true;
                    }
                }
            }

            [HarmonyPatch(typeof(Board))]
            public static class Board_Patch
            {

                [HarmonyPostfix]
                [HarmonyPatch("Update")]
                private static void Update(Board __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.UnlimitedSun))
                    {
                        __instance.theSun = 10000;
                    }
                    __instance.freeCD = ModFeatures.GetActive(ModFeatures.ModType.DeveloperMode);
                    if (ModFeatures.GetActive(ModFeatures.ModType.ColumnPlant))
                    {
                        Board.BoardTag newTag = __instance.boardTag;
                        newTag.isColumn = true;
                        __instance.boardTag = newTag;
                    }
                }
            }

            [HarmonyPatch(typeof(Plant))]
            public static class Plant_Patch
            {

                [HarmonyPrefix]
                [HarmonyPatch("TakeDamage", new Type[] { typeof(int), typeof(int) })]
                static bool TakeDamage(Plant __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoTakeDamagePlant))
                    {
                        __instance.isCrashed = false;
                        __instance.dying = false;
                        __instance.thePlantHealth = __instance.thePlantMaxHealth;
                        return false;
                    }

                    return true;
                }

                [HarmonyPrefix]
                [HarmonyPatch("Crashed")]
                static bool Crashed(Plant __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoTakeDamagePlant))
                    {
                        __instance.isCrashed = false;
                        __instance.dying = false;
                        __instance.thePlantHealth = __instance.thePlantMaxHealth;
                        return false;
                    }

                    return true;
                }

                [HarmonyPrefix]
                [HarmonyPatch("Die")]
                static bool Die(Plant __instance)
                {
                    if (ModFeatures.GetActive(ModFeatures.ModType.NoTakeDamagePlant))
                    {
                        __instance.isCrashed = false;
                        __instance.dying = false;
                        __instance.thePlantHealth = __instance.thePlantMaxHealth;
                        return false;
                    }

                    return true;
                }
            }

            [HarmonyPatch(typeof(GameAPP))]
            public static class GameAPP_Patch
            {
                [HarmonyPrefix]
                [HarmonyPatch("Update")]
                private static void Update()
                {
                    GameAPP.developerMode = ModFeatures.GetActive(ModFeatures.ModType.DeveloperMode);
                }
            }
        }
    }
}
#endif