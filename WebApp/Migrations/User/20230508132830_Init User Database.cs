using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations.User
{
    /// <inheritdoc />
    public partial class InitUserDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserAddresses_AspNetUsers_AddressId1",
                table: "AspNetUserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserAddresses_UserProfiles_UserId",
                table: "AspNetUserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_AspNetUsers_UserId",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserAddresses",
                table: "AspNetUserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserAddresses_AddressId1",
                table: "AspNetUserAddresses");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "AspNetUserAddresses");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserAddresses",
                newName: "AppUserAddresses");

            migrationBuilder.AlterColumn<string>(
                name: "AddressId",
                table: "AppUserAddresses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserAddresses",
                table: "AppUserAddresses",
                columns: new[] { "UserId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAddresses_AddressId",
                table: "AppUserAddresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserAddresses_AppUsers_UserId",
                table: "AppUserAddresses",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserAddresses_AspNetUsers_AddressId",
                table: "AppUserAddresses",
                column: "AddressId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AspNetUsers_UserId",
                table: "AppUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserAddresses_AppUsers_UserId",
                table: "AppUserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserAddresses_AspNetUsers_AddressId",
                table: "AppUserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AspNetUsers_UserId",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserAddresses",
                table: "AppUserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_AppUserAddresses_AddressId",
                table: "AppUserAddresses");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "AppUserAddresses",
                newName: "AspNetUserAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "AspNetUserAddresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AddressId1",
                table: "AspNetUserAddresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserAddresses",
                table: "AspNetUserAddresses",
                columns: new[] { "UserId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserAddresses_AddressId1",
                table: "AspNetUserAddresses",
                column: "AddressId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserAddresses_AspNetUsers_AddressId1",
                table: "AspNetUserAddresses",
                column: "AddressId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserAddresses_UserProfiles_UserId",
                table: "AspNetUserAddresses",
                column: "UserId",
                principalTable: "UserProfiles",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_AspNetUsers_UserId",
                table: "UserProfiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
