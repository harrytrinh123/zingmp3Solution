using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Lyrics).HasMaxLength(1000);
            builder.Property(x => x.SongImage).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SongUrl).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LoveCount).HasDefaultValue(0);
            builder.Property(x => x.ListenCount).HasDefaultValue(0);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Musician).HasMaxLength(200);
            builder.Property(x => x.Duration).HasMaxLength(20);
            builder.Property(x => x.SingersString).HasMaxLength(200);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Category).WithMany(x => x.Songs).HasForeignKey(x => x.CategoryId);
        }
    }
}
