using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp.Server.Configurations
{
    public class BangDiemConfigurations : IEntityTypeConfiguration<BangDiem>
    {
        public void Configure(EntityTypeBuilder<BangDiem> builder)
        {
            builder.ToTable("BangDiems");
            builder.HasKey(c => c.Id);
            builder.HasOne(t => t.SinhVien).WithMany(pc => pc.BangDiems)
              .HasForeignKey(pc => pc.MSV);
            builder.HasOne(t => t.MonHoc).WithMany(pc => pc.BangDiems)
              .HasForeignKey(pc => pc.MaMonHoc);
        }
    }
}
