using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Data.Migrations
{
    public partial class rustam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banners",
                columns: table => new
                {
                    banner_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    banner_path = table.Column<string>(nullable: false),
                    custumer_name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banners", x => x.banner_id);
                });

            migrationBuilder.CreateTable(
                name: "live_tv",
                columns: table => new
                {
                    live_tv_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    live_path = table.Column<string>(nullable: true),
                    live_photo_path = table.Column<string>(nullable: false),
                    live_title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_live_tv", x => x.live_tv_id);
                });

            migrationBuilder.CreateTable(
                name: "newsType",
                columns: table => new
                {
                    news_type_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    news_type_name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsType", x => x.news_type_id);
                });

            migrationBuilder.CreateTable(
                name: "sportCategories",
                columns: table => new
                {
                    sport_category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sport_category_name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sportCategories", x => x.sport_category_id);
                });

            migrationBuilder.CreateTable(
                name: "magazine",
                columns: table => new
                {
                    magazine_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    magazine_adress = table.Column<string>(nullable: true),
                    magazine_fifth_photo_path = table.Column<string>(nullable: true),
                    magazine_first_photo_path = table.Column<string>(nullable: false),
                    magazine_fourth_photo_path = table.Column<string>(nullable: true),
                    magazine_latitude = table.Column<string>(maxLength: 50, nullable: true),
                    magazine_longitude = table.Column<string>(maxLength: 50, nullable: true),
                    magazine_second_photo_path = table.Column<string>(nullable: true),
                    magazine_third_photo_path = table.Column<string>(nullable: true),
                    product_name = table.Column<string>(maxLength: 50, nullable: true),
                    product_price = table.Column<string>(nullable: true),
                    product_title = table.Column<string>(maxLength: 50, nullable: true),
                    product_txt = table.Column<string>(nullable: true),
                    sport_category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_magazine", x => x.magazine_id);
                    table.ForeignKey(
                        name: "FK_magazine_ToTablesport_catgory",
                        column: x => x.sport_category_id,
                        principalTable: "sportCategories",
                        principalColumn: "sport_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Melumat",
                columns: table => new
                {
                    melumat_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    melumat_adress = table.Column<string>(maxLength: 50, nullable: true),
                    melumat_photo_path = table.Column<string>(nullable: true),
                    melumat_txt = table.Column<string>(nullable: true),
                    sport_category_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melumat", x => x.melumat_id);
                    table.ForeignKey(
                        name: "FK_Melumat_ToTable_sport_categories",
                        column: x => x.sport_category_id,
                        principalTable: "sportCategories",
                        principalColumn: "sport_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    news_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    news_added_date = table.Column<string>(maxLength: 50, nullable: true),
                    news_big_title = table.Column<string>(nullable: true),
                    news_first_photo_path = table.Column<string>(nullable: true),
                    news_first_video_path = table.Column<string>(nullable: true),
                    news_name = table.Column<string>(maxLength: 50, nullable: true),
                    news_title = table.Column<string>(nullable: false),
                    news_txt = table.Column<string>(nullable: false),
                    news_type_id = table.Column<int>(nullable: false),
                    news_views = table.Column<int>(nullable: false),
                    optional_adress = table.Column<string>(maxLength: 50, nullable: true),
                    optional_latitude = table.Column<string>(maxLength: 50, nullable: true),
                    optional_longitude = table.Column<string>(maxLength: 50, nullable: true),
                    sport_category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.news_id);
                    table.ForeignKey(
                        name: "FK_news_ToTablenews_type",
                        column: x => x.news_type_id,
                        principalTable: "newsType",
                        principalColumn: "news_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_news_ToTablesport_type",
                        column: x => x.sport_category_id,
                        principalTable: "sportCategories",
                        principalColumn: "sport_category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    abstract_comment_type = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    author_name = table.Column<string>(maxLength: 50, nullable: false),
                    comment_date = table.Column<string>(maxLength: 50, nullable: true),
                    comment_txt = table.Column<string>(nullable: false),
                    melumat_id = table.Column<int>(nullable: true),
                    news_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK_comments_ToTablemalumats",
                        column: x => x.melumat_id,
                        principalTable: "Melumat",
                        principalColumn: "melumat_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_comments_ToTablenews",
                        column: x => x.news_id,
                        principalTable: "news",
                        principalColumn: "news_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    photo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    news_id = table.Column<int>(nullable: true),
                    photo_added_data = table.Column<string>(maxLength: 50, nullable: true),
                    photo_name = table.Column<string>(maxLength: 50, nullable: false),
                    photo_path = table.Column<string>(nullable: false),
                    photo_title = table.Column<string>(maxLength: 50, nullable: false),
                    photo_views = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.photo_id);
                    table.ForeignKey(
                        name: "FK_photos_ToTable_news",
                        column: x => x.news_id,
                        principalTable: "news",
                        principalColumn: "news_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    video_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    news_id = table.Column<int>(nullable: true),
                    video_added_date = table.Column<string>(maxLength: 50, nullable: true),
                    video_name = table.Column<string>(maxLength: 50, nullable: false),
                    video_path = table.Column<string>(nullable: false),
                    video_title = table.Column<string>(maxLength: 50, nullable: false),
                    video_views = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.video_id);
                    table.ForeignKey(
                        name: "FK_videos_ToTable_news",
                        column: x => x.news_id,
                        principalTable: "news",
                        principalColumn: "news_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_melumat_id",
                table: "comments",
                column: "melumat_id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_news_id",
                table: "comments",
                column: "news_id");

            migrationBuilder.CreateIndex(
                name: "IX_magazine_sport_category_id",
                table: "magazine",
                column: "sport_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Melumat_sport_category_id",
                table: "Melumat",
                column: "sport_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_news_news_type_id",
                table: "news",
                column: "news_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_news_sport_category_id",
                table: "news",
                column: "sport_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_photos_news_id",
                table: "photos",
                column: "news_id");

            migrationBuilder.CreateIndex(
                name: "IX_videos_news_id",
                table: "videos",
                column: "news_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banners");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "live_tv");

            migrationBuilder.DropTable(
                name: "magazine");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "videos");

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
