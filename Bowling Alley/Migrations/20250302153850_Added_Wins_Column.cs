using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bowling_Alley.Migrations
{
    /// <inheritdoc />
    public partial class Added_Wins_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Players");
        }
    }
}
