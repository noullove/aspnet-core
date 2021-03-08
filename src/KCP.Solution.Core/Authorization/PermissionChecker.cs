using Abp.Authorization;
using KCP.Solution.Authorization.Roles;
using KCP.Solution.Authorization.Users;

namespace KCP.Solution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
