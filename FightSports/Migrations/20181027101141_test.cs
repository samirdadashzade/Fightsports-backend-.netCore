using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "news_id",
                table: "comments",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "news_id",
                table: "comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
