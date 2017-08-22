using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using A8Dashboard.Models.CustomUserIdentity;
using A8DashBoard.Data.A8Product;

namespace A8DashBoard.Data.CustomUserIdentity
{
    public class ApplicationUserStore :
     UserStore<User, Role, int,
     UserLogin, UserRole, UserClaim>, IUserStore<User, int>, IDisposable
    {
        public ApplicationUserStore()
            : base(new A8ProdcutEntities())
        {
            base.DisposeContext = true;
        }

        public ApplicationUserStore(DbContext context)
            : base(context)
        {
        }

        public override Task CreateAsync(User user)
        {
            return base.CreateAsync(user);
        }
    }
}