using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Project.ABP.Authorization.Roles;
using Project.ABP.Authorization.Users;
using Project.ABP.MultiTenancy;

namespace Project.ABP.EntityFrameworkCore
{
    public class ABPDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPDbContext(DbContextOptions<ABPDbContext> options)
            : base(options)
        {
        }
    }
}
