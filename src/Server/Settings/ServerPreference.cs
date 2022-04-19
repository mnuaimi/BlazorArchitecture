using System.Linq;
using HelpDesk.Architecture.Shared.Constants.Localization;
using HelpDesk.Architecture.Shared.Settings;

namespace HelpDesk.Architecture.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}