using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BazodanowaAplikacjaWebowa.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProduct_AddReleaseYearAndRatingFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
