using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using KCP.Solution.Controllers;

namespace KCP.Solution.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SolutionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
