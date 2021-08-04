using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserName).HasMaxLength(25);
            builder.Property(x => x.Password).HasMaxLength(25);

            builder.HasOne(u => u.Role).WithOne(r => r.User).HasForeignKey<Role>(r => r.UserId);
        }
    }
}
