//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A8Dashboard.Models.A8Product
{
    using CustomUserIdentity;
    using System;
    using System.Collections.Generic;

    public partial class AdminSiteAccess
    {
        public int AdminSiteAccessId { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
    
        public virtual User User { get; set; }
    }
}
