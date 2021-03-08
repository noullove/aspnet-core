using Abp.AspNetCore.Mvc.ViewComponents;

namespace KCP.Solution.Web.Views
{
    public abstract class SolutionViewComponent : AbpViewComponent
    {
        protected SolutionViewComponent()
        {
            LocalizationSourceName = SolutionConsts.LocalizationSourceName;
        }
    }
}
