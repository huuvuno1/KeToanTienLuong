﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ketoantienluongEntities : DbContext
    {
        public ketoantienluongEntities()
            : base("name=ketoantienluongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bangcc> bangccs { get; set; }
        public virtual DbSet<dmbp> dmbps { get; set; }
        public virtual DbSet<dmcv> dmcvs { get; set; }
        public virtual DbSet<thamsoluong> thamsoluongs { get; set; }
        public virtual DbSet<thamsothuetncn> thamsothuetncns { get; set; }
        public virtual DbSet<dmtk> dmtks { get; set; }
        public virtual DbSet<chitietsocai> chitietsocais { get; set; }
        public virtual DbSet<vsocai> vsocais { get; set; }
        public virtual DbSet<nguoidung> nguoidungs { get; set; }
        public virtual DbSet<dmnh> dmnhs { get; set; }
        public virtual DbSet<chitietphieuketoan> chitietphieuketoans { get; set; }
        public virtual DbSet<phieuketoan> phieuketoans { get; set; }
        public virtual DbSet<dmnv> dmnvs { get; set; }
        public virtual DbSet<giaybaono> giaybaonoes { get; set; }
        public virtual DbSet<phieuchi> phieuchis { get; set; }
        public virtual DbSet<chitietbangcc> chitietbangccs { get; set; }
        public virtual DbSet<bangluongnhanvien> bangluongnhanviens { get; set; }
        public virtual DbSet<socai> socais { get; set; }
    
        public virtual ObjectResult<laydsbangluong_Result> laydsbangluong(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<laydsbangluong_Result>("laydsbangluong", thangParameter, namParameter);
        }
    }
}
