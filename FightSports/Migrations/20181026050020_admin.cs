using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "admin_password",
                table: "admin",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "admin_password",
                table: "admin",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
