﻿using TruongMamNon.BackendApi.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruongMamNon.BackendApi.Data.Configurations
{
    internal class PhongBanConfiguration : IEntityTypeConfiguration<PhongBan>
    {
        public void Configure(EntityTypeBuilder<PhongBan> builder)
        {
            builder.ToTable("PhongBans");
            builder.HasKey(x => x.MaPhongBan);
            builder.Property(x => x.TenPhongBan).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GhiChu).IsRequired(false);
        }
    }
}