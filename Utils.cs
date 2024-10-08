using PVZ_Hyper_Fusion.AssetStore;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace PVZ_Hyper_Fusion
{
    internal class Utils
    {
#if USE_TEXTURE
        internal static bool TryReplaceTexture2D(Texture2D ogTexture)
        {
            if (ogTexture is not null)
            {
                if (TextureStore.textureDict.ContainsKey(ogTexture.name))
                {
                    string textturePath = TextureStore.textureDict[ogTexture.name];

                    ImageConversion.LoadImage(ogTexture, File.ReadAllBytes(textturePath));
                    Log.LogDebug("OK! Replaced Texture " + ogTexture.name);
                    ogTexture.name = "replaced_" + ogTexture.name;
                    return true;
                }
            }
            return false;
        }

        internal static Texture2D LoadImage(string path)
        {
            if (!File.Exists(path))
            {
                // Throw an exception if the file does not exist
                throw new FileNotFoundException($"The image file at path '{path}' does not exist.");
            }

            byte[] array = File.ReadAllBytes(path);
            Texture2D texture2D = new Texture2D(2, 2, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None, 1, IntPtr.Zero, null);
            ImageConversion.LoadImage(texture2D, array);
            return texture2D;
        }
#endif
    }
}
