#if UNITY_EDITOR
using System.Globalization;
using UnityEngine;

namespace GameFramework.Recovery
{
    // The original SDK locale queries are not available in the Editor.
    // Read the actual host language, then use the original SDK numeric codes.
    internal static class LocalEditorLangLocaleAdapter
    {
        internal static int GetLocaleLanguageCode()
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Chinese:
                case SystemLanguage.ChineseSimplified: return 1;
                case SystemLanguage.ChineseTraditional: return 2;
                case SystemLanguage.English: return 0;
                case SystemLanguage.French: return 3;
                case SystemLanguage.Italian: return 4;
                case SystemLanguage.German: return 5;
                case SystemLanguage.Spanish: return 6;
                case SystemLanguage.Dutch: return 8;
                case SystemLanguage.Russian: return 9;
                case SystemLanguage.Korean: return 10;
                case SystemLanguage.Japanese: return 11;
                case SystemLanguage.Hungarian: return 12;
                case SystemLanguage.Portuguese: return 13;
                case SystemLanguage.Arabic: return 14;
                case SystemLanguage.Norwegian: return 15;
                case SystemLanguage.Polish: return 16;
                case SystemLanguage.Turkish: return 17;
                case SystemLanguage.Romanian: return 19;
                case SystemLanguage.Hindi: return 21;
                case SystemLanguage.Indonesian: return 22;
                case SystemLanguage.Vietnamese: return 23;
                case SystemLanguage.Thai: return 26;
                case SystemLanguage.Swedish: return 27;
                case SystemLanguage.Finnish: return 28;
                case SystemLanguage.Czech: return 29;
            }
            string culture = CultureInfo.CurrentUICulture.Name.ToLowerInvariant();
            if (culture.StartsWith("zh"))
                return culture.Contains("tw") || culture.Contains("hk") || culture.Contains("hant") ? 2 : 1;
            string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            if (language == "bn") return 24;
            if (language == "ms") return 25;
            return -1;
        }

        internal static int GetSystemLanguage()
        {
            return GetLocaleLanguageCode();
        }
    }
}
#endif
