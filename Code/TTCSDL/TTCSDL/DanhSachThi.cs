//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTCSDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhSachThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhSachThi()
        {
            this.DanhSachThuBais = new HashSet<DanhSachThuBai>();
        }
    
        public int IDThi { get; set; }
        public Nullable<int> SBD { get; set; }
        public Nullable<int> IDThiSinh { get; set; }
        public Nullable<int> IDDotThi { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DotThi DotThi { get; set; }
        public virtual ThiSinh ThiSinh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachThuBai> DanhSachThuBais { get; set; }
    }
}
