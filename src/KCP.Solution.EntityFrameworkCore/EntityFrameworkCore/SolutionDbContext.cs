using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KCP.Solution.Authorization.Roles;
using KCP.Solution.Authorization.Users;
using KCP.Solution.MultiTenancy;

namespace KCP.Solution.EntityFrameworkCore
{
    public class SolutionDbContext : AbpZeroDbContext<Tenant, Role, User, SolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SolutionDbContext(DbContextOptions<SolutionDbContext> options)
            : base(options)
        {
        }
    }
}
