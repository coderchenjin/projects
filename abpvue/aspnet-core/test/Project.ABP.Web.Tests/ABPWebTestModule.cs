using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Project.ABP.EntityFrameworkCore;
using Project.ABP.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Project.ABP.Web.Tests
{
    [DependsOn(
        typeof(ABPWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABPWebTestModule : AbpModule
    {
        public ABPWebTestModule(ABPEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPWebMvcModule).Assembly);
        }
    }
}