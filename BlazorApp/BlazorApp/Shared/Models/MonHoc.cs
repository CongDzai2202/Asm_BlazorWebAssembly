using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class MonHoc
    {
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set;}
        public List<BangDiem> BangDiems { get; set; }

    }
}
