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
    
    public partial class dmnv
    {
        public string manv { get; set; }
        public string tenv { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public string diachi { get; set; }
        public string masothue { get; set; }
        public string gioitinh { get; set; }
        public string macv { get; set; }
        public string mabp { get; set; }
        public string mabl { get; set; }
        public Nullable<double> hesoluong { get; set; }
        public string bangcap { get; set; }
        public string trinhdo { get; set; }
        public Nullable<int> songuoiphuthuoc { get; set; }
        public Nullable<int> trangthai { get; set; }
    
        public virtual bacluong bacluong { get; set; }
        public virtual dmbp dmbp { get; set; }
        public virtual dmcv dmcv { get; set; }
    }
}