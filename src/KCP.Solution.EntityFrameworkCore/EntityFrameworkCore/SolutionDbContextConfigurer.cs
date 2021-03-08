using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace KCP.Solution.EntityFrameworkCore
{
    public static class SolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SolutionDbContext> builder, string connectionString)
        {
            builder.UseOracle(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SolutionDbContext> builder, DbConnection connection)
        {
            builder.UseOracle(connection);
        }
    }
}
