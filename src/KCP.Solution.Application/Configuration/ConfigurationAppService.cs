using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using KCP.Solution.Configuration.Dto;

namespace KCP.Solution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
