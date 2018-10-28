using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FightSports.Migrations
{
    public partial class mc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "melumat_comments");

            migrationBuilder.AddColumn<int>(
                name: "melumat_id",
                table: "comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_comments_melumat_id",
                table: "comments",
                column: "melumat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_ToTablemalumats",
                table: "comments",
                column: "melumat_id",
                principalTable: "Melumat",
                principalColumn: "melumat_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_ToTablemalumats",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_melumat_id",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "melumat_id",
                table: "comments");

            migrationBuilder.CreateTable(
                name: "melumat_comments",
                columns: table => new
                {
                    melumat_comment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    melumat_comment_author_name = table.Column<string>(maxLength: 50, nullable: true),
                    melumat_comment_date = table.Column<string>(maxLength: 50, nullable: true),
                    melumat_comment_txt = table.Column<string>(nullable: true),
                    melumat_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_melumat_comments", x => x.melumat_comment_id);
                    table.ForeignKey(
                        name: "FK_melumat_comments_ToTablemelumat_id",
                        column: x => x.melumat_id,
                        principalTable: "Melumat",
                        principalColumn: "melumat_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_melumat_comments_melumat_id",
                table: "melumat_comments",
                column: "melumat_id");
        }
    }
}
