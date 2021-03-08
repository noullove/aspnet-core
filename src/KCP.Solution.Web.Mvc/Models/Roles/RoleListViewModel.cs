using System.Collections.Generic;
using KCP.Solution.Roles.Dto;

namespace KCP.Solution.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
