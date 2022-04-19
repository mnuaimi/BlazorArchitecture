using HelpDesk.Architecture.Shared.Settings;
using System.Threading.Tasks;
using HelpDesk.Architecture.Shared.Wrapper;

namespace HelpDesk.Architecture.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}