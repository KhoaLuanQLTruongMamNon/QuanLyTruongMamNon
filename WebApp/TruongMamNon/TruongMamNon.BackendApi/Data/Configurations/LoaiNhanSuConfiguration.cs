﻿using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    public class LoaiNhanSuConfiguration : IEntityTypeConfiguration<LoaiNhanSu>
    {
        public void Configure(EntityTypeBuilder<LoaiNhanSu> builder)
        {
            builder.ToTable("LoaiNhanSus");
            builder.HasKey(x => x.MaLoaiNhanSu);
            builder.Property(x => x.TenLoaiNhanSu).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}