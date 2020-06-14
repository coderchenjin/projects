using System.Threading.Tasks;
using Abp.Application.Services;
using Project.ABP.Authorization.Accounts.Dto;

namespace Project.ABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
