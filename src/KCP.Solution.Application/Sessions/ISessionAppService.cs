using System.Threading.Tasks;
using Abp.Application.Services;
using KCP.Solution.Sessions.Dto;

namespace KCP.Solution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
