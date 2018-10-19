using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "banners");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "live_tv");

            migrationBuilder.DropTable(
                name: "magazine_photos");

            migrationBuilder.DropTable(
                name: "melumat_comments");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "videos");

            migrationBuilder.DropTable(
                name: "magazine");

            migrationBuilder.DropTable(
                name: "Melumat");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "newsType");

            migrationBuilder.DropTable(
                name: "sportCategories");
        }
    }
}
