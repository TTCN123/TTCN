using System;
using System.Collections.Generic;

#nullable disable

namespace QLSP.models
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            Sps = new HashSet<Sp>();
        }

        public string Maloai { get; set; }
        public string Tenloai { get; set; }

        public virtual ICollection<Sp> Sps { get; set; }
    }
}
