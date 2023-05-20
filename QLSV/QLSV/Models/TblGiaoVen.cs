using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV.Models
{
    public partial class TblGiaoVen
    {
        public TblGiaoVen()
        {
            TblDiems = new HashSet<TblDiem>();
        }

        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public string Nguoicapnhat { get; set; }
        public int MaGv { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public byte? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }

        public virtual ICollection<TblDiem> TblDiems { get; set; }
    }
}
