using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV.Models
{
    public partial class TblMonHoc
    {
        public TblMonHoc()
        {
            TblDiems = new HashSet<TblDiem>();
        }

        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public string Nguoicapnhat { get; set; }
        public int MaMh { get; set; }
        public string TenMh { get; set; }
        public int SoTc { get; set; }

        public virtual ICollection<TblDiem> TblDiems { get; set; }
    }
}
