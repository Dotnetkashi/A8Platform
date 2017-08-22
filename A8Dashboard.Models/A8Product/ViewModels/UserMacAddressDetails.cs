using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaptivePortal.API.Models;
using A8Dashboard.Models.A8Product;
using A8Dashboard.Models.CustomUserIdentity;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class UserMacAddressDetails
    {
        public User objUser { get; set; }
        public MacAddress objMacAddress { get; set; }
        public UsersAddress objAddress { get; set; }
    }
}