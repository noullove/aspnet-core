using System.Collections.Generic;
using KCP.Solution.Roles.Dto;

namespace KCP.Solution.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}