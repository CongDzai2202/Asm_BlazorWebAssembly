using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class BangDiem
    {
        public int Id { get; set; }
        public int MSV { get; set; }
        public SinhVien SinhVien { get; set; }
        public int MaMonHoc { get; set; }
        public MonHoc MonHoc { get; set; }
        public double DiemThuong { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemCuoiKy { get; set; }
        public double DiemTongKet { get; set; }
    }
}
