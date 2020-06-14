using Abp.Authorization;
using Project.ABP.Authorization.Roles;
using Project.ABP.Authorization.Users;

namespace Project.ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
