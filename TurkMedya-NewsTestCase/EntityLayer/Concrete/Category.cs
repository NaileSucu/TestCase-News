using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public string CategoryId { get; set; }// string convert hatası nedeniyle int olarak kullanmadım.
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Color { get; set; }

        //public List<NewsDetail> NewsDetail { get; set; }
        //public List<RelatedNews> RelatedNews { get; set; }
    }
}
