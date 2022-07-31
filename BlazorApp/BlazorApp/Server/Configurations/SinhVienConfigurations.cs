using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp.Server.Configurations
{
    public class SinhVienConfigurations : IEntityTypeConfiguration<SinhVien>
    {
        public void Configure(EntityTypeBuilder<SinhVien> builder)
        {
            builder.ToTable("SinhViens");
            builder.HasKey(c => c.MSV);
            builder.Property(c => c.HoVaTen).IsRequired();
            builder.HasOne(t => t.Lop).WithMany(pc => pc.SinhViens)
                .HasForeignKey(pc => pc.MaLop);
        }
    }
}
