using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class ReturnMacDevices
    {
        public ReturnMacDevices()
        {
            MacAddressList = new List<MacAddesses>();
            objReturn = new StatusReturn();
        }

        public List<MacAddesses> MacAddressList { get; set; }
        public StatusReturn objReturn {get;set;}
    }
}