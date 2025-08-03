using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RWG.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImagePathColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Meals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Meals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
