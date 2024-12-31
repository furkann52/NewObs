using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexToNumara : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                    migrationBuilder.CreateIndex(
            name: "IX_Ogrenciler_Numara",
            table: "Ogrenciler",
            column: "Numara",
            unique: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
