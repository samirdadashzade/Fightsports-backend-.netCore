using FightSports.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightSports
{
    public class ViewModel
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public int? AdminPassword { get; set; }
        public int BannerId { get; set; }
        public string CustumerName { get; set; }
        public string BannerPath { get; set; }
        public int CommentId { get; set; }
        public string AuthorName { get; set; }
        public string CommentTxt { get; set; }
        public string CommentDate { get; set; }
        public int NewsIdFk { get; set; }
        public int LiveTvId { get; set; }
        public string LivePath { get; set; }
        public string LiveTitle { get; set; }
        public int MagazineId { get; set; }
        public string ProductName { get; set; }
        public string MagazineAdress { get; set; }
        public int? MagazineLongitude { get; set; }
        public int? MagazineLatitude { get; set; }
        public string ProductTxt { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public int SportCategoryIdFK { get; set; }
        public string MagazinePhotoName { get; set; }
        public int MagazinePhotoId { get; set; }
        public string MagazinePhotoPath{ get; set; }
        public int MagazineIdFK { get; set; }
        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBigTitle { get; set; }
        public string NewsTxt { get; set; }
        public int NewsViews { get; set; }
        public string NewsAddedDate { get; set; }
        public int? OptionalLongitude { get; set; }
        public int? OptionalLatitude { get; set; }
        public int NewsTypeIdFk { get; set; }
        public int SportCategoryIdFKNews { get; set; }
        public string OptionalAdress { get; set; }
        public int NewsTypeId { get; set; }
        public string NewsTypeName { get; set; }
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoTitle { get; set; }
        public int? PhotoViews { get; set; }
        public string PhotoAddedDate { get; set; }
        public int SportCategoryId { get; set; }
        public string SportCategoryName{ get; set; }
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public string VideoTitle { get; set; }
        public int VideoViews { get; set; }
        public string VideoPath { get; set; }
        public string VideoAddedDate { get; set; }

    }
}