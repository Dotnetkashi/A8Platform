using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class ReturnRegisterFormListData
    {

        public ReturnRegisterFormListData()
        {
            ReteurnRegisterFormList = new List<ReturnRegisterFormData>();
        }
        public List<ReturnRegisterFormData> ReteurnRegisterFormList { get; set; }
    }

}