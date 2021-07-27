using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    class Song_PlaylistConfiguration : IEntityTypeConfiguration<Song_Playlist>
    {
        public void Configure(EntityTypeBuilder<Song_Playlist> builder)
        {
            builder.ToTable("Song_Playlists");
            builder.HasKey(t => new { t.SongId, t.PlaylistId });
  
            builder.HasOne(sp => sp.Song).WithMany(s => s.Song_Playlists).HasForeignKey(sp => sp.SongId);
            builder.HasOne(sp => sp.Playlist).WithMany(s => s.Song_Playlists).HasForeignKey(sp => sp.PlaylistId);
        }
    }
}
