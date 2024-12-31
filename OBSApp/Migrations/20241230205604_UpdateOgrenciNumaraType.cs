using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBSApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOgrenciNumaraType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numara",
                table: "Ogrenciler",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.CreateIndex(
       name: "IX_Ogrenciler_Numara",
       table: "Ogrenciler",
       column: "Numara",
       unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numara",
                table: "Ogrenciler",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
