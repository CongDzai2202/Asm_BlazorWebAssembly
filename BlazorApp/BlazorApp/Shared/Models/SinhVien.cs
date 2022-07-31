using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class SinhVien
    {
        public int MSV { get; set; }
        public string HoVaTen { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public string Email { get; set; }
        public int MaLop { get; set; }
        public Lop Lop { get; set; }
        public List<BangDiem> BangDiems { get; set; }


    }
}
