using System.Threading.Tasks;
using Abp.Application.Services;
using Project.ABP.Sessions.Dto;

namespace Project.ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
