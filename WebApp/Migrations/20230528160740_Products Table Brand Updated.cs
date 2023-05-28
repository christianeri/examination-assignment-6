using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductsTableBrandUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Audio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Audio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Home" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Home" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Home" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                columns: new[] { "Brand", "Category" },
                values: new object[] { null, "Outdoor" });
        }
    }
}
