//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ThuongPhat
    {
        public string MaThuongPhat { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string LiDo { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
