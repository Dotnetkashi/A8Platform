using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class AutoLoginStatus
    {
        public AutoLoginStatus()
        {
            StatusReturn = new StatusReturn();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StatusReturn StatusReturn { get; set; }
    }
}