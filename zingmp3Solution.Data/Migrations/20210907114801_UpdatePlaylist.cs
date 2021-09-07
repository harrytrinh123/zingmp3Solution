using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zingmp3Solution.Data.Migrations
{
    public partial class UpdatePlaylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Playlists",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("50741d25-d3fa-46de-8853-afe9bd461174"),
                column: "ConcurrencyStamp",
                value: "30c815b1-fc67-450d-8cd5-55219771a9cb");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5af8cad4-1f9e-444a-97f9-5cbcb5ab6117"),
                column: "ConcurrencyStamp",
                value: "8288a74b-0c4f-4c78-aaac-42edc12de15c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1e0b8ba0-86ce-476d-942f-536b3443d68b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5317121c-3842-4a4e-b3eb-2c37e9d53142"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "445031ac-7949-47a6-b7ee-db5e889f02dd", "AQAAAAEAACcQAAAAEIObD/hHPac9+kFBGr965Jfr5tVkxpGABkNrklGQ+/Qbhy5AanPOhAtnfA1EmWB0ZQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc4d5e8b-a6b9-4a8b-b99d-053b67754cc5", "AQAAAAEAACcQAAAAEPyH8akuiqHWNOL6hz/KDRsiJawZJ7IRSDwedd4dcoV2AyLRUkt2rUd7jgBWFvGHJA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf16d629-2b25-4bb4-8f5c-6221d665ea38"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a05ac28-d59b-4d96-bac6-1186a6cd7bfc", "AQAAAAEAACcQAAAAEDkWcyQ9gF9+NAMp2hD+sL2LG4isM+01w8CrA1y3RIaDwDa6QIvnKI58W1uT4ESrPg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Playlists");

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
    }
}
