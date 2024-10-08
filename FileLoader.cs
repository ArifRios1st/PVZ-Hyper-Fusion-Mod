using UnityEngine;
using System.Text.Json;
using PVZ_Hyper_Fusion.AssetStore;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace PVZ_Hyper_Fusion
{
    internal static class FileLoader
    {
        internal enum AssetType
        {
            Textures,
            Strings,
            Dumps,
        }

#if USE_TRANSLATE
        internal static void LoadStrings()
        {
            string textureDir = getAssetDir(AssetType.Strings);
            if (!Directory.Exists(textureDir))
            {
                Directory.CreateDirectory(textureDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(textureDir, "*.json", SearchOption.AllDirectories))
                {
                    string fileName = Path.GetFileNameWithoutExtension(filepath);
                    StringStore.stringsDict[fileName] = filepath;
                    string jsonString = File.ReadAllText(filepath);
                    if (fileName.EndsWith("_strings"))
                    {
                        Dictionary<string, string> dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                        foreach (var (key, value) in dictionary)
                        {
                            StringStore.translationString[key] = value;
                        }
                    }
                    else if (fileName.EndsWith("_regexs"))
                    {
                        Dictionary<string, string> dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                        foreach (var (key, value) in dictionary)
                        {
                            StringStore.translationStringRegex[key] = value;
                        }
                    }
                }
                SaveStrings();
                DumpJson();
            }
            catch (Exception e)
            {
                Log.LogError("Error loading String. ");
                Log.LogError(e.GetType() + " " + e.Message);
            }
            Log.LogInfo("Strings loaded successfully.");
        }
#endif

#if USE_TEXTURE
        internal static void LoadTextures()
        {
            string jsonDir = getAssetDir(AssetType.Textures);
            if (!Directory.Exists(jsonDir))
            {
                Directory.CreateDirectory(jsonDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(jsonDir, "*.png", SearchOption.AllDirectories))
                {
                    Texture2D texture2D = Utils.LoadImage(filepath);
                    TextureStore.textureDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
                }
            }
            catch (Exception e)
            {
                Log.LogError("Error loading Texture. ");
                Log.LogError(e.GetType() + " " + e.Message);
            }
            Log.LogInfo("Textures loaded successfully.");
        }
#endif

#if USE_TRANSLATE
        internal static void SaveStrings()
        {
            string stringDir = getAssetDir(AssetType.Strings);
            if (!Directory.Exists(stringDir))
            {
                Directory.CreateDirectory(stringDir);
            }

            string translationStringRegex = JsonSerializer.Serialize(StringStore.translationStringRegex, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            File.WriteAllText(Path.Combine(stringDir, "translation_regexs.json"), translationStringRegex);

            string translationString = JsonSerializer.Serialize(StringStore.translationString, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            File.WriteAllText(Path.Combine(stringDir, "translation_strings.json"), translationString);
        }

        public static void DumpJson()
        {
            string stringDir = getAssetDir(AssetType.Dumps);
            if (!Directory.Exists(stringDir))
            {
                Directory.CreateDirectory(stringDir);
            }
            string LawnStrings = Resources.Load<TextAsset>("LawnStrings").text;
            string ZombieStrings = Resources.Load<TextAsset>("ZombieStrings").text;
            File.WriteAllText(Path.Combine(stringDir, "LawnStrings.json"), LawnStrings);
            File.WriteAllText(Path.Combine(stringDir, "ZombieStrings.json"), ZombieStrings);
        }
#endif

        private static string getAssetDir(AssetType assetType)
        {
            return Path.Combine("Mods", "PVZ_Hyper_Fusion", assetType.ToString());
        }
    }
}
