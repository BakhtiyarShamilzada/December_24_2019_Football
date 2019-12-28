using Microsoft.EntityFrameworkCore.Migrations;

namespace December_24_2019_Football.Migrations
{
    public partial class FootballPlayerImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FootballPlayers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "FootballPlayers");
        }
    }
}
