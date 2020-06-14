using System.Threading.Tasks;
using Project.ABP.Configuration.Dto;

namespace Project.ABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
