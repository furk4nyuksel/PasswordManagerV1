//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PasswordManager
    {
        public int PasswordManagerId { get; set; }
        public string SiteName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual AppUser AppUser { get; set; }
    }
}
