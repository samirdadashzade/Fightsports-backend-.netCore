using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FightSports.Models
{
    public partial class CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext : DbContext
    {
        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext()
        {
        }

        public CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext(DbContextOptions<CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Banners> Banners { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<LiveTv> LiveTv { get; set; }
        public virtual DbSet<Magazine> Magazine { get; set; }
        public virtual DbSet<MagazinePhotos> MagazinePhotos { get; set; }
        public virtual DbSet<Melumat> Melumat { get; set; }
        public virtual DbSet<MelumatComments> MelumatComments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<SportCategories> SportCategories { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rustam\\Documents\\fightSports.mdf;Integrated Security=True;Connect Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.AdminEmail)
                    .HasColumnName("admin_email")
                    .HasMaxLength(50);

                entity.Property(e => e.AdminName)
                    .HasColumnName("admin_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AdminPassword).HasColumnName("admin_password");
            });

            modelBuilder.Entity<Banners>(entity =>
            {
                entity.HasKey(e => e.BannerId);

                entity.ToTable("banners");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.BannerPath)
                    .IsRequired()
                    .HasColumnName("banner_path");

                entity.Property(e => e.CustumerName)
                    .HasColumnName("custumer_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("comments");

                entity.HasIndex(e => e.NewsId);

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasColumnName("author_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CommentDate)
                    .HasColumnName("comment_date")
                    .HasMaxLength(50);

                entity.Property(e => e.CommentTxt)
                    .IsRequired()
                    .HasColumnName("comment_txt");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comments_ToTablenews");
            });

            modelBuilder.Entity<LiveTv>(entity =>
            {
                entity.ToTable("live_tv");

                entity.Property(e => e.LiveTvId).HasColumnName("live_tv_id");

                entity.Property(e => e.LivePath).HasColumnName("live_path");

                entity.Property(e => e.LiveTitle)
                    .HasColumnName("live_title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Magazine>(entity =>
            {
                entity.ToTable("magazine");

                entity.HasIndex(e => e.SportCategoryId);

                entity.Property(e => e.MagazineId).HasColumnName("magazine_id");

                entity.Property(e => e.MagazineAdress).HasColumnName("magazine_adress");

                entity.Property(e => e.MagazineFirstPhotoPath)
                    .IsRequired()
                    .HasColumnName("magazine_first_photo_path");

                entity.Property(e => e.MagazineLatitude).HasColumnName("magazine_latitude");

                entity.Property(e => e.MagazineLongitude).HasColumnName("magazine_longitude");

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnName("product_price");

                entity.Property(e => e.ProductTitle)
                    .HasColumnName("product_title")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductTxt).HasColumnName("product_txt");

                entity.Property(e => e.SportCategoryId).HasColumnName("sport_category_id");

                entity.HasOne(d => d.SportCategory)
                    .WithMany(p => p.Magazine)
                    .HasForeignKey(d => d.SportCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_magazine_ToTablesport_catgory");
            });

            modelBuilder.Entity<MagazinePhotos>(entity =>
            {
                entity.HasKey(e => e.MagazinePhotoId);

                entity.ToTable("magazine_photos");

                entity.HasIndex(e => e.MagazineId);

                entity.Property(e => e.MagazinePhotoId).HasColumnName("magazine_photo_id");

                entity.Property(e => e.MagazineId).HasColumnName("magazine_id");

                entity.Property(e => e.MagazinePhotoName)
                    .HasColumnName("magazine_photo_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MagazinePhotoPath).HasColumnName("magazine_photo_path");

                entity.HasOne(d => d.Magazine)
                    .WithMany(p => p.MagazinePhotos)
                    .HasForeignKey(d => d.MagazineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_magazine_photos_ToTablemagazine");
            });

            modelBuilder.Entity<Melumat>(entity =>
            {
                entity.Property(e => e.MelumatId).HasColumnName("melumat_id");

                entity.Property(e => e.MelumatAdress)
                    .HasColumnName("melumat_adress")
                    .HasMaxLength(50);

                entity.Property(e => e.MelumatPhotoPath).HasColumnName("melumat_photo_path");

                entity.Property(e => e.MelumatTxt).HasColumnName("melumat_txt");

                entity.Property(e => e.SportCategoryId).HasColumnName("sport_category_id");

                entity.HasOne(d => d.SportCategory)
                    .WithMany(p => p.Melumat)
                    .HasForeignKey(d => d.SportCategoryId)
                    .HasConstraintName("FK_Melumat_ToTable_sport_categories");
            });

            modelBuilder.Entity<MelumatComments>(entity =>
            {
                entity.HasKey(e => e.MelumatCommentId);

                entity.ToTable("melumat_comments");

                entity.Property(e => e.MelumatCommentId).HasColumnName("melumat_comment_id");

                entity.Property(e => e.MelumatCommentAuthorName)
                    .HasColumnName("melumat_comment_author_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MelumatCommentDate)
                    .HasColumnName("melumat_comment_date")
                    .HasMaxLength(50);

                entity.Property(e => e.MelumatCommentTxt).HasColumnName("melumat_comment_txt");

                entity.Property(e => e.MelumatId).HasColumnName("melumat_id");

                entity.HasOne(d => d.Melumat)
                    .WithMany(p => p.MelumatComments)
                    .HasForeignKey(d => d.MelumatId)
                    .HasConstraintName("FK_melumat_comments_ToTablemelumat_id");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.HasIndex(e => e.NewsTypeId);

                entity.HasIndex(e => e.SportCategoryId);

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.NewsAddedDate)
                    .HasColumnName("news_added_date")
                    .HasMaxLength(50);

                entity.Property(e => e.NewsBigTitle).HasColumnName("news_big_title");

                entity.Property(e => e.NewsFirstPhotoPath).HasColumnName("news_first_photo_path");

                entity.Property(e => e.NewsFirstVideoPath).HasColumnName("news_first_video_path");

                entity.Property(e => e.NewsName)
                    .HasColumnName("news_name")
                    .HasMaxLength(50);

                entity.Property(e => e.NewsTitle)
                    .IsRequired()
                    .HasColumnName("news_title");

                entity.Property(e => e.NewsTxt)
                    .IsRequired()
                    .HasColumnName("news_txt");

                entity.Property(e => e.NewsTypeId).HasColumnName("news_type_id");

                entity.Property(e => e.NewsViews).HasColumnName("news_views");

                entity.Property(e => e.OptionalAdress)
                    .HasColumnName("optional_adress")
                    .HasMaxLength(50);

                entity.Property(e => e.OptionalLatitude).HasColumnName("optional_latitude");

                entity.Property(e => e.OptionalLongitude).HasColumnName("optional_longitude");

                entity.Property(e => e.SportCategoryId).HasColumnName("sport_category_id");

                entity.HasOne(d => d.NewsType)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_news_ToTablenews_type");

                entity.HasOne(d => d.SportCategory)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.SportCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_news_ToTablesport_type");
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.ToTable("newsType");

                entity.Property(e => e.NewsTypeId).HasColumnName("news_type_id");

                entity.Property(e => e.NewsTypeName)
                    .IsRequired()
                    .HasColumnName("news_type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.ToTable("photos");

                entity.HasIndex(e => e.NewsId);

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.PhotoAddedData)
                    .HasColumnName("photo_added_data")
                    .HasMaxLength(50);

                entity.Property(e => e.PhotoName)
                    .IsRequired()
                    .HasColumnName("photo_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PhotoPath)
                    .IsRequired()
                    .HasColumnName("photo_path");

                entity.Property(e => e.PhotoTitle)
                    .IsRequired()
                    .HasColumnName("photo_title")
                    .HasMaxLength(50);

                entity.Property(e => e.PhotoViews).HasColumnName("photo_views");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_photos_ToTable_news");
            });

            modelBuilder.Entity<SportCategories>(entity =>
            {
                entity.HasKey(e => e.SportCategoryId);

                entity.ToTable("sportCategories");

                entity.Property(e => e.SportCategoryId).HasColumnName("sport_category_id");

                entity.Property(e => e.SportCategoryName)
                    .IsRequired()
                    .HasColumnName("sport_category_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("videos");

                entity.HasIndex(e => e.NewsId);

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.VideoAddedDate)
                    .HasColumnName("video_added_date")
                    .HasMaxLength(50);

                entity.Property(e => e.VideoName)
                    .IsRequired()
                    .HasColumnName("video_name")
                    .HasMaxLength(50);

                entity.Property(e => e.VideoPath)
                    .IsRequired()
                    .HasColumnName("video_path");

                entity.Property(e => e.VideoTitle)
                    .IsRequired()
                    .HasColumnName("video_title")
                    .HasMaxLength(50);

                entity.Property(e => e.VideoViews).HasColumnName("video_views");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_videos_ToTable_news");
            });
        }
    }
}
