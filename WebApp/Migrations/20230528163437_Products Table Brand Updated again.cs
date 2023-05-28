using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductsTableBrandUpdatedagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                column: "BrandName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                column: "BrandName",
                value: null);
        }
    }
}
