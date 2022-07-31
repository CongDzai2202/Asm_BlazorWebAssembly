using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp.Server.Configurations
{
    public class NganhConfigurations : IEntityTypeConfiguration<Nganh>
    {
        public void Configure(EntityTypeBuilder<Nganh> builder)
        {

            builder.ToTable("Nganhs");
            builder.HasKey(c => c.MaNghanh);


        }
    }
}
