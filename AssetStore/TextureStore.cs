#if USE_TEXTURE
using System.Collections;
using UnityEngine;

namespace PVZ_Hyper_Fusion.AssetStore
{
    public static class TextureStore
    {
        internal static Dictionary<string, string> textureDict = new Dictionary<string, string>();

        internal static void Init()
        {
            FileLoader.LoadTextures();
        }

        internal static void Reload() 
        {
            textureDict.Clear();
            FileLoader.LoadTextures();
        }

        public static IEnumerator ReplaceTexturesCoroutine()
        {
            while (true)
            {
                ReplaceTextures();
                yield return new WaitForSeconds(0.5f);  // Adjust this interval as needed
            }
        }

        public static void ReplaceTextures()
        {
            Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
            foreach (Texture2D texture in textures)
            {
                if (texture.name.StartsWith("replaced_"))
                    continue;

                Utils.TryReplaceTexture2D(texture);
            }
        }

        public static void LogAll()
        {
            Log.LogInfo("Logging all TextureStore entries.");
            foreach (KeyValuePair<string, string> entry in textureDict)
            {
                Log.LogInfo("TextureDict Entry: " + entry.Key + " | " + entry.Value);
            }
        }
    }
}
#endif