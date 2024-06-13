using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AllNewsDetail
    {
        public string SectionType { get; set; }
        public string RepeatType { get; set; }
        public bool LazyLoadingEnabled { get; set; }
        public bool TitleVisible { get; set; }
        public int ItemCountInRow { get; set; }
        public object Title { get; set; }
        public object TitleColor { get; set; }
        public object TitleBgColor { get; set; }
        public object SectionBgColor { get; set; }
        public List<ItemList> ItemList { get; set; }
    }
}
