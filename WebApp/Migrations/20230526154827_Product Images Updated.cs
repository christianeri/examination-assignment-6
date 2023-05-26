using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductImagesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                column: "ImageUrl",
                value: "pexels-mwabonje-12562635.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                column: "ImageUrl",
                value: "pexels-sound-on-3761020.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                column: "ImageUrl",
                value: "pexels-min-an-1171585.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                column: "ImageUrl",
                value: "pexels-jens-mahnke-844874.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                column: "ImageUrl",
                value: "pexels-mikhail-nilov-8670204.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                column: "ImageUrl",
                value: "pexels-aidan-jarrett-718981.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                column: "ImageUrl",
                value: "pexels-melvin-buezo-2529148.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                column: "ImageUrl",
                value: "pexels-mike-bird-112285.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                column: "ImageUrl",
                value: "tactical-beard-brown.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/Arr7wiXoPANjNZJq7");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/EK7UVigEhbruvgZT8");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/XoRbi5LTwWpkM2wFA");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/DDsDgqs5WPU77m3r6");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/6mqXsMLWGqLvGyA2A");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/YcEDywrVXUHX7ivo6");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/V2SkRMC2WtcJVtps5");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/WWNVZqzcFPbrEKuk6");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                column: "ImageUrl",
                value: "https://photos.app.goo.gl/MdVkFDjTkGG1FXad9");
        }
    }
}
