using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static EntityLayer.Enums.ContentEnums;

namespace EntityLayer.Concrete
{
    public class NewsDetail
    {
        public string Resource { get; set; }
        public string BodyText { get; set; }
        public bool HasPhotoGallery { get; set; }
        public bool HasVideo { get; set; }
        public string PublishDate { get; set; }
        public string FullPath { get; set; }
        public string ShortText { get; set; }
        public Category Category { get; set; }
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }
        public string ImageUrl { get; set; }
        public string ItemType { get; set; }





    }
}
