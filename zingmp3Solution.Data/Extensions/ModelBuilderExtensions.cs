using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Admin guid
            var adRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adUserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = adRoleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasherAd = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adUserId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin.zingmp3@gmail.com",
                NormalizedEmail = "admin.zingmp3@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasherAd.HashPassword(null, "Zxcv1234!"),
                SecurityStamp = string.Empty,
                FirstName = "Hoang",
                LastName = "Trinh Quoc",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = adRoleId,
                UserId = adUserId
            });

            // User guid
            var usRoleId = new Guid("50741D25-D3FA-46DE-8853-AFE9BD461174");
            var usUserId = new Guid("BF16D629-2B25-4BB4-8F5C-6221D665EA38");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = usRoleId,
                Name = "user",
                NormalizedName = "user",
                Description = "Normal user role"
            });

            var hasher2 = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = usUserId,
                UserName = "normaluser",
                NormalizedUserName = "normaluser",
                Email = "normaluser.zingmp3@gmail.com",
                NormalizedEmail = "normaluser.zingmp3@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher2.HashPassword(null, "Zxcv1234!"),
                SecurityStamp = string.Empty,
                FirstName = "Dat",
                LastName = "Nguyen Hong",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = usRoleId,
                UserId = usUserId
            });

            // User guid
            var vipRoleId = new Guid("5AF8CAD4-1F9E-444A-97F9-5CBCB5AB6117");
            var vipUserId = new Guid("5317121C-3842-4A4E-B3EB-2C37E9D53142");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = vipRoleId,
                Name = "user",
                NormalizedName = "user",
                Description = "Vip user role"
            });

            var hasher3 = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = vipUserId,
                UserName = "vipuser",
                NormalizedUserName = "vipuser",
                Email = "vipuser.zingmp3@gmail.com",
                NormalizedEmail = "vipuser.zingmp3@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher3.HashPassword(null, "Zxcv1234!"),
                SecurityStamp = string.Empty,
                FirstName = "Phuong",
                LastName = "Vo Minh Phuong",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = vipRoleId,
                UserId = vipUserId
            });
        }
    }
}
