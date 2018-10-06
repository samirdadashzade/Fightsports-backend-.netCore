﻿// <auto-generated />
using System;
using FightSports.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FightSports.Migrations
{
    [DbContext(typeof(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext))]
    partial class CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FightSports.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName")
                        .HasColumnName("admin_name")
                        .HasMaxLength(50);

                    b.Property<int?>("AdminPassword")
                        .HasColumnName("admin_password");

                    b.HasKey("AdminId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("FightSports.Models.Banners", b =>
                {
                    b.Property<int>("BannerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("banner_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerPath")
                        .IsRequired()
                        .HasColumnName("banner_path");

                    b.Property<string>("CustumerName")
                        .HasColumnName("custumer_name")
                        .HasMaxLength(50);

                    b.HasKey("BannerId");

                    b.ToTable("banners");
                });

            modelBuilder.Entity("FightSports.Models.Comments", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("comment_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnName("author_name")
                        .HasMaxLength(50);

                    b.Property<string>("CommentDate")
                        .HasColumnName("comment_date")
                        .HasMaxLength(50);

                    b.Property<string>("CommentTxt")
                        .IsRequired()
                        .HasColumnName("comment_txt");

                    b.Property<int>("NewsId")
                        .HasColumnName("news_id");

                    b.HasKey("CommentId");

                    b.HasIndex("NewsId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("FightSports.Models.LiveTv", b =>
                {
                    b.Property<int>("LiveTvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("live_tv_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LivePath")
                        .HasColumnName("live_path");

                    b.Property<string>("LiveTitle")
                        .HasColumnName("live_title")
                        .HasMaxLength(50);

                    b.HasKey("LiveTvId");

                    b.ToTable("live_tv");
                });

            modelBuilder.Entity("FightSports.Models.Magazine", b =>
                {
                    b.Property<int>("MagazineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("magazine_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MagazineAdress")
                        .HasColumnName("magazine_adress")
                        .HasMaxLength(50);

                    b.Property<int?>("MagazineLatitude")
                        .HasColumnName("magazine_latitude");

                    b.Property<int?>("MagazineLongitude")
                        .HasColumnName("magazine_longitude");

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name")
                        .HasMaxLength(50);

                    b.Property<int?>("ProductPrice")
                        .HasColumnName("product_price");

                    b.Property<string>("ProductTitle")
                        .HasColumnName("product_title")
                        .HasMaxLength(50);

                    b.Property<string>("ProductTxt")
                        .HasColumnName("product_txt")
                        .HasMaxLength(50);

                    b.Property<int>("SportCategoryId")
                        .HasColumnName("sport_category_id");

                    b.HasKey("MagazineId");

                    b.HasIndex("SportCategoryId");

                    b.ToTable("magazine");
                });

            modelBuilder.Entity("FightSports.Models.MagazinePhotos", b =>
                {
                    b.Property<int>("MagazinePhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("magazine_photo_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MagazineId")
                        .HasColumnName("magazine_id");

                    b.Property<string>("MagazinePhotoName")
                        .HasColumnName("magazine_photo_name")
                        .HasMaxLength(50);

                    b.Property<string>("MagazinePhotoPath")
                        .HasColumnName("magazine_photo_path");

                    b.HasKey("MagazinePhotoId");

                    b.HasIndex("MagazineId");

                    b.ToTable("magazine_photos");
                });

            modelBuilder.Entity("FightSports.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("news_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewsAddedDate")
                        .HasColumnName("news_added_date")
                        .HasMaxLength(50);

                    b.Property<string>("NewsBigTitle")
                        .HasColumnName("news_big_title");

                    b.Property<string>("NewsName")
                        .HasColumnName("news_name")
                        .HasMaxLength(50);

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasColumnName("news_title");

                    b.Property<string>("NewsTxt")
                        .IsRequired()
                        .HasColumnName("news_txt");

                    b.Property<int>("NewsTypeId")
                        .HasColumnName("news_type_id");

                    b.Property<int>("NewsViews")
                        .HasColumnName("news_views");

                    b.Property<string>("OptionalAdress")
                        .HasColumnName("optional_adress")
                        .HasMaxLength(50);

                    b.Property<int?>("OptionalLatitude")
                        .HasColumnName("optional_latitude");

                    b.Property<int?>("OptionalLongitude")
                        .HasColumnName("optional_longitude");

                    b.Property<int>("SportCategoryId")
                        .HasColumnName("sport_category_id");

                    b.HasKey("NewsId");

                    b.HasIndex("NewsTypeId");

                    b.HasIndex("SportCategoryId");

                    b.ToTable("news");
                });

            modelBuilder.Entity("FightSports.Models.NewsType", b =>
                {
                    b.Property<int>("NewsTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("news_type_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewsTypeName")
                        .IsRequired()
                        .HasColumnName("news_type_name")
                        .HasMaxLength(50);

                    b.HasKey("NewsTypeId");

                    b.ToTable("newsType");
                });

            modelBuilder.Entity("FightSports.Models.Photos", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("photo_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NewsId")
                        .HasColumnName("news_id");

                    b.Property<string>("PhotoAddedData")
                        .HasColumnName("photo_added_data")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoName")
                        .IsRequired()
                        .HasColumnName("photo_name")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnName("photo_path");

                    b.Property<string>("PhotoTitle")
                        .IsRequired()
                        .HasColumnName("photo_title")
                        .HasMaxLength(50);

                    b.Property<int?>("PhotoViews")
                        .HasColumnName("photo_views");

                    b.HasKey("PhotoId");

                    b.HasIndex("NewsId");

                    b.ToTable("photos");
                });

            modelBuilder.Entity("FightSports.Models.SportCategories", b =>
                {
                    b.Property<int>("SportCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sport_category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SportCategoryName")
                        .IsRequired()
                        .HasColumnName("sport_category_name")
                        .HasMaxLength(50);

                    b.HasKey("SportCategoryId");

                    b.ToTable("sportCategories");
                });

            modelBuilder.Entity("FightSports.Models.Videos", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("video_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NewsId")
                        .HasColumnName("news_id");

                    b.Property<string>("VideoAddedDate")
                        .HasColumnName("video_added_date")
                        .HasMaxLength(50);

                    b.Property<string>("VideoName")
                        .IsRequired()
                        .HasColumnName("video_name")
                        .HasMaxLength(50);

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnName("video_path");

                    b.Property<string>("VideoTitle")
                        .IsRequired()
                        .HasColumnName("video_title")
                        .HasMaxLength(50);

                    b.Property<int?>("VideoViews")
                        .HasColumnName("video_views");

                    b.HasKey("VideoId");

                    b.HasIndex("NewsId");

                    b.ToTable("videos");
                });

            modelBuilder.Entity("FightSports.Models.Comments", b =>
                {
                    b.HasOne("FightSports.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK_comments_ToTablenews");
                });

            modelBuilder.Entity("FightSports.Models.Magazine", b =>
                {
                    b.HasOne("FightSports.Models.SportCategories", "SportCategory")
                        .WithMany("Magazine")
                        .HasForeignKey("SportCategoryId")
                        .HasConstraintName("FK_magazine_ToTablesport_catgory");
                });

            modelBuilder.Entity("FightSports.Models.MagazinePhotos", b =>
                {
                    b.HasOne("FightSports.Models.Magazine", "Magazine")
                        .WithMany("MagazinePhotos")
                        .HasForeignKey("MagazineId")
                        .HasConstraintName("FK_magazine_photos_ToTablemagazine");
                });

            modelBuilder.Entity("FightSports.Models.News", b =>
                {
                    b.HasOne("FightSports.Models.NewsType", "NewsType")
                        .WithMany("News")
                        .HasForeignKey("NewsTypeId")
                        .HasConstraintName("FK_news_ToTablenews_type");

                    b.HasOne("FightSports.Models.SportCategories", "SportCategory")
                        .WithMany("News")
                        .HasForeignKey("SportCategoryId")
                        .HasConstraintName("FK_news_ToTablesport_type");
                });

            modelBuilder.Entity("FightSports.Models.Photos", b =>
                {
                    b.HasOne("FightSports.Models.News", "News")
                        .WithMany("Photos")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK_photos_ToTable_news");
                });

            modelBuilder.Entity("FightSports.Models.Videos", b =>
                {
                    b.HasOne("FightSports.Models.News", "News")
                        .WithMany("Videos")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK_videos_ToTable_news");
                });
#pragma warning restore 612, 618
        }
    }
}
