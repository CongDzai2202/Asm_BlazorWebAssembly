
using BlazorApp.Server.Configurations;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Models
{
    public class SinhVienContext:DbContext
    {
        public SinhVienContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BangDiemConfigurations());
            modelBuilder.ApplyConfiguration(new LopConfigurations());
            modelBuilder.ApplyConfiguration(new MonHocConfigurations());
            modelBuilder.ApplyConfiguration(new NganhConfigurations());
            modelBuilder.ApplyConfiguration(new SinhVienConfigurations());


            
        }
        public virtual DbSet<Nganh> Nganhs { get; set; } = null!;
        public virtual DbSet<BangDiem> BangDiems { get; set; } = null!;
        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;

        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;
    }
}
