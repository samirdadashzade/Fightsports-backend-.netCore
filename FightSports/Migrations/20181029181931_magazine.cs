using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class magazine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "magazine_photos");

            migrationBuilder.AddColumn<string>(
                name: "magazine_fifth_photo_path",
                table: "magazine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "magazine_fourth_photo_path",
                table: "magazine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "magazine_second_photo_path",
                table: "magazine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "magazine_third_photo_path",
                table: "magazine",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "magazine_fifth_photo_path",
                table: "magazine");

            migrationBuilder.DropColumn(
                name: "magazine_fourth_photo_path",
                table: "magazine");

            migrationBuilder.DropColumn(
                name: "magazine_second_photo_path",
                table: "magazine");

            migrationBuilder.DropColumn(
                name: "magazine_third_photo_path",
                table: "magazine");

            migrationBuilder.CreateTable(
                name: "magazine_photos",
                columns: table => new
                {
                    magazine_photo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    magazine_id = table.Column<int>(nullable: false),
                    magazine_photo_name = table.Column<string>(maxLength: 50, nullable: true),
                    magazine_photo_path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_magazine_photos", x => x.magazine_photo_id);
                    table.ForeignKey(
                        name: "FK_magazine_photos_ToTablemagazine",
                        column: x => x.magazine_id,
                        principalTable: "magazine",
                        principalColumn: "magazine_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_magazine_photos_magazine_id",
                table: "magazine_photos",
                column: "magazine_id");
        }
    }
}
