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
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Post).WithMany(x => x.LovePosts).HasForeignKey(x => x.PostId);
        }
    }
}
