using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    class LovePostConfiguration : IEntityTypeConfiguration<LovePost>
    {
        public void Configure(EntityTypeBuilder<LovePost> builder)
        {
            builder.ToTable("LovePosts");
            builder.HasKey(t => new { t.UserId, t.PostId });
            builder.HasOne(x => x.Post).WithMany(x => x.LovePosts).HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
