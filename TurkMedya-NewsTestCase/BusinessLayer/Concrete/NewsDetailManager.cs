using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsDetailManager : INewsService
    {
        INewsDetailDal _newsDetailDal;

        public NewsDetailManager(INewsDetailDal newsDetailDal)
        {
            _newsDetailDal = newsDetailDal;
        }

        public List<NewsDetail> TGetList()
        {
            return _newsDetailDal.GetList();
        }
    }


}
