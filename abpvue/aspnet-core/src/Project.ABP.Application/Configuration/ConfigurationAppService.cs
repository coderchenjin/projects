using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Project.ABP.Configuration.Dto;

namespace Project.ABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
