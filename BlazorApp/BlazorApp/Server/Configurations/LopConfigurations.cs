using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp.Server.Configurations
{
    public class LopConfigurations : IEntityTypeConfiguration<Lop>
    {
        public void Configure(EntityTypeBuilder<Lop> builder)
        {
            builder.ToTable("Lops");
            builder.HasKey(c => c.MaLop);
            builder.HasOne(t => t.Nganh).WithMany(pc => pc.Lops)
                .HasForeignKey(c => c.MaNghanh);
        }
    }
}
