using Abp.Application.Services;
using KCP.Solution.MultiTenancy.Dto;

namespace KCP.Solution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

