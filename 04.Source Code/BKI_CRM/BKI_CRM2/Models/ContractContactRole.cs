//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKI_CRM2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContractContactRole
    {
        public decimal Id { get; set; }
        public Nullable<decimal> IdContact { get; set; }
        public Nullable<decimal> IdContract { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsPrimary { get; set; }
        public string VaiTroContact { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Contract Contract { get; set; }
    }
}