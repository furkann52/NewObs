using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDerslerSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersId", "DersAd", "DersKod" },
                values: new object[,]
                {
                    { 1, "İnternet Programcılığı", "BİL201" },
                    { 2, "Nesne Tabanlı Programlama", "BİL202" },
                    { 3, "Veri Tabanı Ve Yönetimi", "BİL203" },
                    { 4, "Görsel Programlama", "BİL204" },
                    { 5, "Adli Bilişim", "BİL205" },
                    { 6, "İngilizce", "BİL206" },
                    { 7, "Matematik", "BİL207" },
                    { 8, "İş Sağlığı Ve Güvenliği", "BİL208" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersId",
                keyValue: 8);
        }
    }
}
