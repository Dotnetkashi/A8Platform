using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A8DashBoard.Models.A8Product.ViewModels
{
    public class FormControlViewModel
    {
        public string fieldlabel { get; set; }
        public string LabelNameToDisplay { get; set; }
        public string controlType { get; set; }
        public string[] arrayValue { get; set; }
        public int FormId { get; set; }
        public string chkOptOrMand { get; set; }
    }
}