using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    public class SingerConfiguration : IEntityTypeConfiguration<Singer>
    {
        public void Configure(EntityTypeBuilder<Singer> builder)
        {
            builder.ToTable("Singers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Dob).IsRequired();
            builder.Property(x => x.Sex).IsRequired();
            builder.Property(x => x.Introduction).HasMaxLength(500);
            builder.Property(x => x.StageName).HasMaxLength(50);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
