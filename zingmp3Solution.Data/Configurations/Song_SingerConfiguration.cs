using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    class Song_SingerConfiguration : IEntityTypeConfiguration<Song_Singer>
    {
        public void Configure(EntityTypeBuilder<Song_Singer> builder)
        {
            builder.ToTable("Song_Singers");
            builder.HasKey(t => new { t.SongId, t.SingerId });

            builder.HasOne(p => p.Song).WithMany(s => s.Song_Singers).HasForeignKey(sp => sp.SongId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Singer).WithMany(s => s.Song_Singers).HasForeignKey(sp => sp.SingerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
