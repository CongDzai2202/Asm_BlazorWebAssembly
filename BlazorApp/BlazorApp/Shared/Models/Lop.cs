using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class Lop
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public string GiaoVien { get; set; }
        public List<SinhVien> SinhViens { get; set; }
        public int MaNghanh { get; set; }
        public Nganh Nganh { get; set; }


    }
}
