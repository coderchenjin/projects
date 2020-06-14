using Abp.Application.Services;
using Project.ABP.MultiTenancy.Dto;

namespace Project.ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

