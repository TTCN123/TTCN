using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV.Models
{
    public partial class TblDiem
    {
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public string Nguoicapnhat { get; set; }
        public int MaMh { get; set; }
        public int MaGv { get; set; }
        public string MaSv { get; set; }
        public int LanHoc { get; set; }
        public double? DiemThiLan1 { get; set; }
        public double? DiemThiLan2 { get; set; }

        public virtual TblGiaoVen MaGvNavigation { get; set; }
        public virtual TblMonHoc MaMhNavigation { get; set; }
        public virtual TblSinhVien MaSvNavigation { get; set; }
    }
}
