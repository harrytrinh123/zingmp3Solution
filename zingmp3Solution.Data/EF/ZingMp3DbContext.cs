using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Configurations;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.EF
{
    public class ZingMp3DbContext : DbContext
    {
        public ZingMp3DbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new LovePostConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new SingerConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<LovePost> LovePosts { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
