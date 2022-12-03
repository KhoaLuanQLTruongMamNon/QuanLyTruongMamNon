using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVus");
            builder.HasKey(x => x.MaChucVu);
            builder.Property(x => x.TenChucVu).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}