using Microsoft.EntityFrameworkCore.Migrations;

namespace December_24_2019_Football.Migrations
{
    public partial class CartImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Carts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Carts");
        }
    }
}
