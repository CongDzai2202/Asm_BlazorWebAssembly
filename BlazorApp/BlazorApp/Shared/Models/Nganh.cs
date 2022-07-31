using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class Nganh
    {
        public int MaNghanh { get; set; } 
        public string TenNganh { get; set; }
        public List<Lop> Lops { get; set; }
    }
}
