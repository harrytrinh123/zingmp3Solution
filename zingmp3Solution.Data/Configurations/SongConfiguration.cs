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
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Playlist).WithMany(x => x.Songs).HasForeignKey(x => x.PlaylistId);
            builder.HasOne(x => x.Category).WithMany(x => x.Songs).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Singer).WithOne(x => x.Song).HasForeignKey<Singer>(s => s.SongId);
        }
    }
}
