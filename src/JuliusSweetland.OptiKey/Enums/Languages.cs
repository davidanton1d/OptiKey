using System.Globalization;
using JuliusSweetland.OptiKey.Properties;

namespace JuliusSweetland.OptiKey.Enums
{
    public enum Languages
    {
        EnglishCanada,
        EnglishUK,
        EnglishUS,
        FrenchFrance,
        GermanGermany,
			  SwedenSwedish
    }

    public static partial class EnumExtensions
    {
        public static string ToDescription(this Languages languages)
        {
            switch (languages)
            {
                case Languages.EnglishCanada: return Resources.ENGLISH_CANADA;
                case Languages.EnglishUK: return Resources.ENGLISH_UK;
                case Languages.EnglishUS: return Resources.ENGLISH_US;
                case Languages.FrenchFrance: return Resources.FRENCH_FRANCE;
								case Languages.GermanGermany: return Resources.GERMAN_GERMANY;
								case Languages.SwedenSwedish: return Resources.ENGLISH_US;
						}

            return languages.ToString();
        }

        public static CultureInfo ToCultureInfo(this Languages languages)
        {
            switch (languages)
            {
                case Languages.EnglishUS: return CultureInfo.GetCultureInfo("en-US");
                case Languages.EnglishUK: return CultureInfo.GetCultureInfo("en-GB");
                case Languages.EnglishCanada: return CultureInfo.GetCultureInfo("en-CA");
                case Languages.FrenchFrance: return CultureInfo.GetCultureInfo("fr-FR");
								case Languages.GermanGermany: return CultureInfo.GetCultureInfo("de-DE");
								case Languages.SwedenSwedish: return CultureInfo.GetCultureInfo("sv-SE");
						}

            return CultureInfo.GetCultureInfo("en-GB");
        }
    }
}
