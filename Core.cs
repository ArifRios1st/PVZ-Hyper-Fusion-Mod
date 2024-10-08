﻿using Il2Cpp;
using MelonLoader;
using UnityEngine;
using HarmonyLib;
using Il2CppTMPro;
using PVZ_Hyper_Fusion.AssetStore;

[assembly: MelonInfo(typeof(PVZ_Hyper_Fusion.Core), "PVZ Hyper Fusion", "0.0.1", "arifrios1st", null)]
[assembly: MelonGame("LanPiaoPiao", "PlantsVsZombiesRH")]

namespace PVZ_Hyper_Fusion
{
    public class Core : MelonMod
    {
        private static DateTime? dtStartToast;
        private static string toast_txt;

        public const string MOD_DIRECTORY = "Mods";

#if USE_TEXTURE
        object replaceTextureRoutine = null;
#endif

        public override void OnInitializeMelon()
        {
#if USE_TEXTURE
            TextureStore.Init();
#endif
#if USE_TRANSLATE
            StringStore.Init();
#endif
        }

#if USE_TEXTURE
        public override void OnLateInitializeMelon()
        {
            replaceTextureRoutine = MelonCoroutines.Start(TextureStore.ReplaceTexturesCoroutine());
        }

        public override void OnDeinitializeMelon()
        {
            MelonCoroutines.Stop(replaceTextureRoutine);
        }
#endif

        public static void ShowToast(string message)
        {
            toast_txt = message;
            dtStartToast = new DateTime?(DateTime.Now);
        }

        public override void OnLateUpdate()
        {
#if USE_MOD
            ModFeatures.OnLateUpdate();
#endif
        }

        public override void OnGUI()
        {
#if USE_MOD

            if (ModFeatures.GetActive(ModFeatures.ModType.Help))
            {
                string text = ModFeatures.GetFeatures();
                int num = 0;
                int num2 = 20;
                foreach (string text2 in text.Split('\n', StringSplitOptions.None))
                {
                    if (text2.Length > num2)
                    {
                        num2 = text2.Length;
                    }
                    num++;
                }
                bool flag4 = GUI.Button(new Rect(10f, 30f, (float)num2 * 10f, (float)num * 16f + 15f), text);
            }
#endif
            if (dtStartToast != null)
            {
                GUI.Button(new Rect(10f, 10f, 200f, 20f), "\n" + toast_txt + "\n");
                TimeSpan? timeSpan = DateTime.Now - dtStartToast;
                TimeSpan t = new TimeSpan(0, 0, 0, 2);
                if (timeSpan > t)
                {
                    dtStartToast = null;
                }
            }
        }

    }
}