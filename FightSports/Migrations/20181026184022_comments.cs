using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "abstract_comment_type",
                table: "comments",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abstract_comment_type",
                table: "comments");
        }
    }
}
