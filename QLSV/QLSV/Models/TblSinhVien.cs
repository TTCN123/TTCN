using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV.Models
{
    public partial class TblSinhVien
    {
        public TblSinhVien()
        {
            TblDiems = new HashSet<TblDiem>();
        }

        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public string Nguoicapnhat { get; set; }
        public string MaSv { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public byte? GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TblDiem> TblDiems { get; set; }
    }
}
