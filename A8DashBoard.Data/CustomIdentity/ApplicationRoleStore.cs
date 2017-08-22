using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using A8Dashboard.Models.CustomUserIdentity;

namespace A8DashBoard.Data.CustomUserIdentity
{
    public class ApplicationRoleStore
    : RoleStore<Role, int, UserRole>,
    IQueryableRoleStore<Role, int>,
    IRoleStore<Role, int>, IDisposable
    {
        public ApplicationRoleStore()
            : base(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }

        public ApplicationRoleStore(System.Data.Entity.DbContext context)
            : base(context)
        {
        }
        public override Task CreateAsync(Role role)
        {
            return base.CreateAsync(role);
        }
    }
}