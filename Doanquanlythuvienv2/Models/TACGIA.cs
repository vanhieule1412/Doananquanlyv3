//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doanquanlythuvienv2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TACGIA
    {
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string MaSach { get; set; }
    
        public virtual SACH SACH { get; set; }
    }
}
