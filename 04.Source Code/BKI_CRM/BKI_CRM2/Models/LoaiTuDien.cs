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
    
    public partial class LoaiTuDien
    {
        public LoaiTuDien()
        {
            this.TuDiens = new HashSet<TuDien>();
        }
    
        public decimal Id { get; set; }
        public string TenLoaiTuDien { get; set; }
        public string MaLoaiTuDien { get; set; }
    
        public virtual ICollection<TuDien> TuDiens { get; set; }
    }
}
