﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "magazine_second_photo_path",
                table: "magazine",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValueSql: "(N'')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "magazine_second_photo_path",
                table: "magazine",
                nullable: true,
                defaultValueSql: "(N'')",
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
