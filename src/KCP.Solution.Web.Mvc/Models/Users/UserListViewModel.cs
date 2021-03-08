using System.Collections.Generic;
using KCP.Solution.Roles.Dto;

namespace KCP.Solution.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
