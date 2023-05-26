using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "Brand", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { "A11", "Andersson", "Audio", "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ", "https://photos.app.goo.gl/Arr7wiXoPANjNZJq7", "BHS 3.3", 399m },
                    { "A22", "JBL", "Audio", "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.", "https://photos.app.goo.gl/EK7UVigEhbruvgZT8", "T570 BT", 399m },
                    { "A33", "Weber", "Home", "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.", "https://photos.app.goo.gl/XoRbi5LTwWpkM2wFA", "Master-Touch® GBS E-5750", 3290m },
                    { "A44", "Dreame", "Home", "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!", "https://photos.app.goo.gl/DDsDgqs5WPU77m3r6", "D9 Max", 3390m },
                    { "A55", "Beurer", "Home", "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.", "https://photos.app.goo.gl/6mqXsMLWGqLvGyA2A", "BM 28", 449m },
                    { "A66", "Lundhags", "Shoes", "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.", "https://photos.app.goo.gl/YcEDywrVXUHX7ivo6", "U Park", 2175m },
                    { "A77", "Asics", "Shoes", "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.", "https://photos.app.goo.gl/V2SkRMC2WtcJVtps5", "W Gt-1000", 1099m },
                    { "A88", "Everest", "Shoes", "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.", "https://photos.app.goo.gl/WWNVZqzcFPbrEKuk6", "U Comfort Sandal", 379m },
                    { "A99", "Mil-Tec", "Outdoor", "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakr och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://photos.app.goo.gl/MdVkFDjTkGG1FXad9", "Taktiskt skägg", 249m }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ArticleNumber", "TagId" },
                values: new object[,]
                {
                    { "A11", 1 },
                    { "A11", 3 },
                    { "A22", 1 },
                    { "A22", 3 },
                    { "A33", 1 },
                    { "A44", 1 },
                    { "A44", 2 },
                    { "A55", 1 },
                    { "A66", 1 },
                    { "A77", 1 },
                    { "A88", 1 },
                    { "A88", 3 },
                    { "A99", 1 },
                    { "A99", 2 },
                    { "A99", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A11", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A11", 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A22", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A22", 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A33", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A44", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A44", 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A55", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A66", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A77", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A88", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A88", 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A99", 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A99", 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ArticleNumber", "TagId" },
                keyValues: new object[] { "A99", 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A11");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A22");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A33");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A55");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A66");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A77");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "A99");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");
        }
    }
}
