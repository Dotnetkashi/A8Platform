using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class LoginWIthNewMacAddressModel
    {
        public string UserName { get; set; }

        public string MacAddress { get; set; }

        public string Password { get; set; }

        public string BrowserName { get; set; }
        public string UserAgentName { get; set; }
        public int SiteId { get; set; }
        public string OperatingSystem { get; set; }

        public bool IsMobile { get; set; }

    }
}