using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[,]
                {
                    { 1, "Grace a cette formation vous saurez créer votre site web", "Créer votre site web avec ASP.NET Core", "asp-net-core" },
                    { 2, "Grace à cette formation Blah blah Blah", "Creer votre site web avec PHP", "php" },
                    { 3, "Apprenez a faire du jardinage", "Devenez un pro du jardinage", "pro-jardinage" },
                    { 4, "un pro de la photo, Blah blah Blah", "Photo Pro", "photo-pro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
