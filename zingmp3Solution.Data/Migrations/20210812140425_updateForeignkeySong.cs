using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zingmp3Solution.Data.Migrations
{
    public partial class updateForeignkeySong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("50741d25-d3fa-46de-8853-afe9bd461174"),
                column: "ConcurrencyStamp",
                value: "951e0697-5778-42d1-8aeb-5393dfee98b9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5af8cad4-1f9e-444a-97f9-5cbcb5ab6117"),
                column: "ConcurrencyStamp",
                value: "3054cf66-19f5-4777-90f3-a496ef148f36");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "548a7ef2-4606-4035-872c-b59d35c54c5d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5317121c-3842-4a4e-b3eb-2c37e9d53142"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed37e94d-c10e-4734-96f6-a82e9fed5fe2", "AQAAAAEAACcQAAAAEHCUKUhziH6zhGdT8R1hMUavIeQKcWzhl3NnlZo0gaVi+VInghPxIbCauYPNOaLr1A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e75e12f-068e-4a95-8fd1-0de42885271d", "AQAAAAEAACcQAAAAEA+gtA8UstbIBVi3KSPqXrj3r9zg5twSntvH64LOUjmUZacWtlD7j+vUyrcO5TruJQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf16d629-2b25-4bb4-8f5c-6221d665ea38"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9894d08-19c9-4133-8a3b-793f6758af78", "AQAAAAEAACcQAAAAEBBdEc9p1TBm3eP/1PtgVTVxbACko718oZ/QCqj/AhHPoMHOEc0h4YZYpi9NfIVwdg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("50741d25-d3fa-46de-8853-afe9bd461174"),
                column: "ConcurrencyStamp",
                value: "255d5c64-b80a-4901-8603-6caed7c7753d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5af8cad4-1f9e-444a-97f9-5cbcb5ab6117"),
                column: "ConcurrencyStamp",
                value: "95f943b3-f16c-454c-baa3-3b953c2978b7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0b55ab88-1bfd-41fd-95e6-bdf29b72a217");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5317121c-3842-4a4e-b3eb-2c37e9d53142"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8423c9d2-8ea5-4e1a-8700-1d6b67821e17", "AQAAAAEAACcQAAAAEGAe/ruHpcyg7373AfX6Ik3FFC8OUYuhfdj+Cy8pVJ6U2HCPnGXDjWh1hwI8Hr0muQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79690431-3026-403a-ad19-62ed79467be2", "AQAAAAEAACcQAAAAECTDwJhAlo2XF0Mx45SegxJaQR8GrLprpIuPeouMJ/bJG0jxBgbomrAr9vlPtz7SdQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf16d629-2b25-4bb4-8f5c-6221d665ea38"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f605be71-7f23-441f-aec1-40a7b7d3d190", "AQAAAAEAACcQAAAAELXCdp0r430h6lWbJHqYv6XGKm1qn3fOrbfXvKDJCqJpgcoZUGG/s9yNJiCNAQFo9g==" });
        }
    }
}
