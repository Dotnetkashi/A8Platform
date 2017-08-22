using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8Dashboard.Models.CustomUserIdentity
{
    public class Role : IdentityRole<int, UserRole>, IRole<int>
    {
        public string Description { get; set; }

        public Role() : base() { }
        public Role(string name)
            : this()
        {
            this.Name = name;
        }

        public Role(string name, string description)
            : this(name)
        {
            this.Description = description;
        }
    }
}