using Abp.Application.Services.Dto;

namespace KCP.Solution.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

