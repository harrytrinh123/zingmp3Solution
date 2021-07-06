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
            throw new NotImplementedException();
        }
    }
}
