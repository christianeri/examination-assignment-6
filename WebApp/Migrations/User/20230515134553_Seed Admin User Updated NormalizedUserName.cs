using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations.User
{
    /// <inheritdoc />
    public partial class SeedAdminUserUpdatedNormalizedUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8f00d990-7a1b-4e4a-866c-4c6f68573439", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "91ffdb23-e225-4616-b662-a966efa8fede", 0, "6f0ca6da-0b6a-4c1c-8f56-7c798ab7020d", "admin@system.com", false, " ", " ", " ", false, null, null, "ADMIN@SYSTEM.COM", "AQAAAAIAAYagAAAAEA6YglBaPWoEomNTjl/xg2ILt8QRWSvBzTqtoWTHaAZ/fBbk5dGoIFGDoom2HCGJbw==", null, false, "48e88063-8a10-4a60-87ac-6a99e025bbd4", false, "admin@system.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f00d990-7a1b-4e4a-866c-4c6f68573439", "91ffdb23-e225-4616-b662-a966efa8fede" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f00d990-7a1b-4e4a-866c-4c6f68573439", "91ffdb23-e225-4616-b662-a966efa8fede" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f00d990-7a1b-4e4a-866c-4c6f68573439");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91ffdb23-e225-4616-b662-a966efa8fede");

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
    }
}
