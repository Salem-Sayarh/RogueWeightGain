using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RWG.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meals_ID",
                table: "Meals");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_Title",
                table: "Meals",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meals_Title",
                table: "Meals");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ID",
                table: "Meals",
                column: "ID");
        }
    }
}
