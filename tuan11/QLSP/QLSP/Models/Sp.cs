using System;
using System.Collections.Generic;

#nullable disable

namespace QLSP.models
{
    public partial class Sp
    {
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public string Maloai { get; set; }
        public double? Dongia { get; set; }
        public int? Sl { get; set; }

        public virtual LoaiSp MaloaiNavigation { get; set; }
    }
}
