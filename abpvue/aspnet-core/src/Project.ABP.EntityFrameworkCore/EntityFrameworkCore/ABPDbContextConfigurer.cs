using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Project.ABP.EntityFrameworkCore
{
    public static class ABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
