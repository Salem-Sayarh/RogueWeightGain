using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RWG.Migrations
{
    /// <inheritdoc />
    public partial class UpdateID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meals_Title",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Meals",
                newName: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ID",
                table: "Meals",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meals_ID",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Meals",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_Title",
                table: "Meals",
                column: "Title");
        }
    }
}
