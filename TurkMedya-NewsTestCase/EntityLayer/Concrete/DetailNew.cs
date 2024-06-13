using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DetailNew
    {
        public PageLayoutInf HeaderAd { get; set; }
        public NewsDetail NewsDetail { get; set; }
        public PageLayoutInf FooterAd { get; set; }
        public Multimedia Multimedia { get; set; }
        public List<ItemListBasic> ItemList { get; set; }
        public RelatedNews RelatedNews { get; set; }
        public Video Video { get; set; }
        public PhotoGallery PhotoGallery { get; set; }

    }
}
