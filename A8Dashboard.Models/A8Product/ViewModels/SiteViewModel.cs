﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptivePortal.API.ViewModels
{
    public class SiteViewModel
    {
        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public string OrgName { get; set; }

        public string CmpName { get; set; }
    }

    public class SitelistViewModel
    {
        public SitelistViewModel()
        {
            SiteViewlist = new List<SiteViewModel>();
        }
        public List<SiteViewModel> SiteViewlist { get; set; }

    }
}