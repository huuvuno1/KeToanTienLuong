//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeToanTienLuong
{
    using System;
    using System.Collections.Generic;
    
    public partial class bacluong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bacluong()
        {
            this.dmnvs = new HashSet<dmnv>();
        }
    
        public string mabl { get; set; }
        public string noidung { get; set; }
        public Nullable<double> tien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dmnv> dmnvs { get; set; }
    }
}