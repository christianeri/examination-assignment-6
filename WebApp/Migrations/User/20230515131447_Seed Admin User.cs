using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations.User
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c50658-b723-4189-927f-9779a8b8b6c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7fa1e2d-1829-4279-a00b-2bbc5a66a0a3", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "74669f63-a9b1-4dbc-bd24-66b91ecfb83f", 0, "15971758-7fd7-4917-a697-aa8695058711", null, false, "System", "", "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEFtuqgrU1CvjfTa3+3draYQROdA12RABDB5ThZNx51NXX7Q1ZzmYD7ScbMkRCcvIQg==", null, false, "aeca1518-5434-45a1-b420-d4e9a1b43bfe", false, "administrator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f4c50658-b723-4189-927f-9779a8b8b6c0", null, "System Administrator", "SYSTEM ADMINISTRATOR" });
        }
    }
}
