using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RelatedNews
    {
        public bool HasPhotoGallery { get; set; }
        public bool HasVideo { get; set; }
        public string PublishDate { get; set; }
        public string ShortText { get; set; }
        public Category Category { get; set; }
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ItemType { get; set; }
        public bool TitleVisible { get; set; }
    }
}
