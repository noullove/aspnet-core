using System.Threading.Tasks;
using Abp.Application.Services;
using KCP.Solution.Authorization.Accounts.Dto;

namespace KCP.Solution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
