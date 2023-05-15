using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations.User
{
    /// <inheritdoc />
    public partial class SeedAdminUserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7fa1e2d-1829-4279-a00b-2bbc5a66a0a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74669f63-a9b1-4dbc-bd24-66b91ecfb83f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "959aafcf-2988-40d9-a9fe-60c5bae5bce2", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ae491ea7-0aa8-4845-98a7-bc8dbaadf9e7", 0, "811a9fe2-7f4e-4dfd-b975-b6fce6f7abd1", "administrator@system.com", false, " ", "", " ", false, null, null, null, "AQAAAAIAAYagAAAAEEYJZedODXRsNqc6tMztTnsnX00lveFAw2JcvThjSCWRSYmUwLelxkgiBWxh/3QwDQ==", null, false, "d0be753f-a86d-4885-823a-82f8c220a891", false, "administrator@system.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "959aafcf-2988-40d9-a9fe-60c5bae5bce2", "ae491ea7-0aa8-4845-98a7-bc8dbaadf9e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "959aafcf-2988-40d9-a9fe-60c5bae5bce2", "ae491ea7-0aa8-4845-98a7-bc8dbaadf9e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "959aafcf-2988-40d9-a9fe-60c5bae5bce2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae491ea7-0aa8-4845-98a7-bc8dbaadf9e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7fa1e2d-1829-4279-a00b-2bbc5a66a0a3", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "74669f63-a9b1-4dbc-bd24-66b91ecfb83f", 0, "15971758-7fd7-4917-a697-aa8695058711", null, false, "System", "", "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEFtuqgrU1CvjfTa3+3draYQROdA12RABDB5ThZNx51NXX7Q1ZzmYD7ScbMkRCcvIQg==", null, false, "aeca1518-5434-45a1-b420-d4e9a1b43bfe", false, "administrator" });
        }
    }
}
