using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeparatedBrandsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName" },
                values: new object[,]
                {
                    { 1, "Andersson" },
                    { 2, "Weber" },
                    { 3, "Dreame" },
                    { 4, "Beurer" },
                    { 5, "Everest" },
                    { 6, "Asics" },
                    { 7, "Mil-Tec" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 1, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 2, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 3, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 4, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 5, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 6, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                columns: new[] { "Brand", "BrandId", "BrandName" },
                values: new object[] { null, 5, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                columns: new[] { "Brand", "BrandId", "BrandName", "Description" },
                values: new object[] { null, 7, null, "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11",
                column: "Brand",
                value: "Andersson");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22",
                column: "Brand",
                value: "JBL");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33",
                column: "Brand",
                value: "Weber");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44",
                column: "Brand",
                value: "Dreame");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55",
                column: "Brand",
                value: "Beurer");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66",
                column: "Brand",
                value: "Lundhags");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77",
                column: "Brand",
                value: "Asics");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88",
                column: "Brand",
                value: "Everest");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99",
                columns: new[] { "Brand", "Description" },
                values: new object[] { "Mil-Tec", "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakr och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat." });
        }
    }
}
