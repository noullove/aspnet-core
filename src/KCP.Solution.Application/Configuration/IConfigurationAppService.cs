using System.Threading.Tasks;
using KCP.Solution.Configuration.Dto;

namespace KCP.Solution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
