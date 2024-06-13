using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Video
    {
        public string ShortText { get; set; }
        public string BodyText { get; set; }
        public string VideoUrl { get; set; }
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ItemType { get; set; }
        public bool TitleVisible { get; set; }
    }
}
