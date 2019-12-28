using Microsoft.EntityFrameworkCore.Migrations;

namespace December_24_2019_Football.Migrations
{
    public partial class StadiumImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Stadiums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Stadiums");
        }
    }
}
