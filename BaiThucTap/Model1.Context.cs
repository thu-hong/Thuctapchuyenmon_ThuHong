﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiThucTap
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class quanlytrangsucEntities1 : DbContext
    {
        public quanlytrangsucEntities1()
            : base("name=quanlytrangsucEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietPN> ChiTietPNs { get; set; }
        public virtual DbSet<ChiTietUD> ChiTietUDs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTPhanQuyen> CTPhanQuyens { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiTrangSuc> LoaiTrangSucs { get; set; }
        public virtual DbSet<LuongNgay> LuongNgays { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thang> Thangs { get; set; }
        public virtual DbSet<ThuongPhat> ThuongPhats { get; set; }
        public virtual DbSet<TrangSuc> TrangSucs { get; set; }
        public virtual DbSet<UuDai> UuDais { get; set; }
    
        [DbFunction("quanlytrangsucEntities1", "dsnhanvien")]
        public virtual IQueryable<dsnhanvien_Result> dsnhanvien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dsnhanvien_Result>("[quanlytrangsucEntities1].[dsnhanvien]()");
        }
    
        [DbFunction("quanlytrangsucEntities1", "dtngay")]
        public virtual IQueryable<dtngay_Result> dtngay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dtngay_Result>("[quanlytrangsucEntities1].[dtngay](@ngay)", ngayParameter);
        }
    
        [DbFunction("quanlytrangsucEntities1", "dtngay1")]
        public virtual IQueryable<dtngay1_Result> dtngay1(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dtngay1_Result>("[quanlytrangsucEntities1].[dtngay1](@ngay)", ngayParameter);
        }
    
        [DbFunction("quanlytrangsucEntities1", "dtthang")]
        public virtual IQueryable<dtthang_Result> dtthang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dtthang_Result>("[quanlytrangsucEntities1].[dtthang](@thang, @nam)", thangParameter, namParameter);
        }
    
        [DbFunction("quanlytrangsucEntities1", "dtthang1")]
        public virtual IQueryable<dtthang1_Result> dtthang1(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<dtthang1_Result>("[quanlytrangsucEntities1].[dtthang1](@thang, @nam)", thangParameter, namParameter);
        }
    
        [DbFunction("quanlytrangsucEntities1", "getmahd1")]
        public virtual IQueryable<getmahd1_Result> getmahd1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getmahd1_Result>("[quanlytrangsucEntities1].[getmahd1]()");
        }
    
        [DbFunction("quanlytrangsucEntities1", "getmahd2")]
        public virtual IQueryable<getmahd2_Result> getmahd2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getmahd2_Result>("[quanlytrangsucEntities1].[getmahd2]()");
        }
    
        [DbFunction("quanlytrangsucEntities1", "hangtonkho")]
        public virtual IQueryable<hangtonkho_Result> hangtonkho(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<hangtonkho_Result>("[quanlytrangsucEntities1].[hangtonkho](@thang, @nam)", thangParameter, namParameter);
        }
    
        [DbFunction("quanlytrangsucEntities1", "HangTonKho4")]
        public virtual IQueryable<HangTonKho4_Result> HangTonKho4(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HangTonKho4_Result>("[quanlytrangsucEntities1].[HangTonKho4](@thang, @nam)", thangParameter, namParameter);
        }
    
        public virtual int deleHD1(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleHD1", mahdParameter);
        }
    
        public virtual int deleteNhanVien(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNhanVien", manvParameter);
        }
    
        public virtual ObjectResult<dttheongay_Result> dttheongay(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dttheongay_Result>("dttheongay", ngayParameter);
        }
    
        public virtual ObjectResult<dttheongay1_Result> dttheongay1(Nullable<System.DateTime> ngay)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dttheongay1_Result>("dttheongay1", ngayParameter);
        }
    
        public virtual ObjectResult<dttheothang_Result> dttheothang(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dttheothang_Result>("dttheothang", thangParameter, namParameter);
        }
    
        public virtual ObjectResult<dttheothang1_Result> dttheothang1(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dttheothang1_Result>("dttheothang1", thangParameter, namParameter);
        }
    
        public virtual ObjectResult<hangtonkhoaaa_Result> hangtonkhoaaa(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hangtonkhoaaa_Result>("hangtonkhoaaa", thangParameter, namParameter);
        }
    
        public virtual ObjectResult<hdtrangsucchuathanhtoan_Result> hdtrangsucchuathanhtoan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hdtrangsucchuathanhtoan_Result>("hdtrangsucchuathanhtoan");
        }
    
        public virtual int insertCTPN(string maPN, Nullable<int> soLuong, Nullable<double> giaNhap, string tenTS, string maLoai, byte[] hinhAnh, string donVi)
        {
            var maPNParameter = maPN != null ?
                new ObjectParameter("MaPN", maPN) :
                new ObjectParameter("MaPN", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var giaNhapParameter = giaNhap.HasValue ?
                new ObjectParameter("GiaNhap", giaNhap) :
                new ObjectParameter("GiaNhap", typeof(double));
    
            var tenTSParameter = tenTS != null ?
                new ObjectParameter("TenTS", tenTS) :
                new ObjectParameter("TenTS", typeof(string));
    
            var maLoaiParameter = maLoai != null ?
                new ObjectParameter("MaLoai", maLoai) :
                new ObjectParameter("MaLoai", typeof(string));
    
            var hinhAnhParameter = hinhAnh != null ?
                new ObjectParameter("HinhAnh", hinhAnh) :
                new ObjectParameter("HinhAnh", typeof(byte[]));
    
            var donViParameter = donVi != null ?
                new ObjectParameter("DonVi", donVi) :
                new ObjectParameter("DonVi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertCTPN", maPNParameter, soLuongParameter, giaNhapParameter, tenTSParameter, maLoaiParameter, hinhAnhParameter, donViParameter);
        }
    
        public virtual ObjectResult<selectalluudai1_Result> selectalluudai1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectalluudai1_Result>("selectalluudai1");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int themHD1(string makh, string maud, string username)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var maudParameter = maud != null ?
                new ObjectParameter("maud", maud) :
                new ObjectParameter("maud", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themHD1", makhParameter, maudParameter, usernameParameter);
        }
    
        public virtual int themncc(string tenncc, string diachi, Nullable<int> sdt)
        {
            var tennccParameter = tenncc != null ?
                new ObjectParameter("tenncc", tenncc) :
                new ObjectParameter("tenncc", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themncc", tennccParameter, diachiParameter, sdtParameter);
        }
    
        public virtual ObjectResult<TraCuu_LichSuMua_Result> TraCuu_LichSuMua(string soDienThoai)
        {
            var soDienThoaiParameter = soDienThoai != null ?
                new ObjectParameter("soDienThoai", soDienThoai) :
                new ObjectParameter("soDienThoai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraCuu_LichSuMua_Result>("TraCuu_LichSuMua", soDienThoaiParameter);
        }
    
        public virtual int update_Soluongton(string maTS, Nullable<int> soluongTon)
        {
            var maTSParameter = maTS != null ?
                new ObjectParameter("MaTS", maTS) :
                new ObjectParameter("MaTS", typeof(string));
    
            var soluongTonParameter = soluongTon.HasValue ?
                new ObjectParameter("SoluongTon", soluongTon) :
                new ObjectParameter("SoluongTon", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Soluongton", maTSParameter, soluongTonParameter);
        }
    
        public virtual int update_Soluongton1(string maTS, Nullable<int> soLuong)
        {
            var maTSParameter = maTS != null ?
                new ObjectParameter("MaTS", maTS) :
                new ObjectParameter("MaTS", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_Soluongton1", maTSParameter, soLuongParameter);
        }
    
        public virtual ObjectResult<uudaimoinhat1_Result> uudaimoinhat1(string maUD)
        {
            var maUDParameter = maUD != null ?
                new ObjectParameter("MaUD", maUD) :
                new ObjectParameter("MaUD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uudaimoinhat1_Result>("uudaimoinhat1", maUDParameter);
        }
    
        public virtual int xoancc(string mancc)
        {
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("xoancc", manccParameter);
        }
    
        public virtual ObjectResult<xuathangtonkho_Result> xuathangtonkho(Nullable<int> thang, Nullable<int> nam)
        {
            var thangParameter = thang.HasValue ?
                new ObjectParameter("thang", thang) :
                new ObjectParameter("thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<xuathangtonkho_Result>("xuathangtonkho", thangParameter, namParameter);
        }
    }
}
