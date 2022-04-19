using HelpDesk.Architecture.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}