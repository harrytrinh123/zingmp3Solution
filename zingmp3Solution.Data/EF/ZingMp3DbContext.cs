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
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new FollowingConfiguration());
            modelBuilder.ApplyConfiguration(new LovePostConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SingerConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new Song_PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new Song_SingerConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<LovePost> LovePosts { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Song_Playlist> Song_Playlists { get; set; }
        public DbSet<Song_Singer> Song_Singers { get; set; }
    }
}
