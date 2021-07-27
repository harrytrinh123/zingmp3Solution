using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    class FollowingConfiguration : IEntityTypeConfiguration<Following>
    {
        public void Configure(EntityTypeBuilder<Following> builder)
        {
            builder.HasKey(t => new { t.UserId, t.FollowerId });
            builder.ToTable("Followings");

            builder.HasOne(f => f.User).WithMany(u => u.Followings).HasForeignKey(f => f.UserId);
        }
    }
}
