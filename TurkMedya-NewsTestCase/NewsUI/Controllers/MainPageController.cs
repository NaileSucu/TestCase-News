using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NewsUI.Helpers;
using NuGet.Protocol.Core.Types;
using Newtonsoft.Json;
using NewsUI.ViewModels;
using static EntityLayer.Enums.ContentEnums;
using System.Drawing.Printing;

namespace NewsUI.Controllers
{
    public class MainPageController : Controller
    {
        //private readonly INewsService _newsService;

        //public MainPageController(INewsService newsService)
        //{
        //    _newsService = newsService;
        //}
        public IActionResult Index(int page = 1, int pageSize = 5)
		{
            var result = Helpers.ApiConsumer.Get<string>(@"https://www.turkmedya.com.tr/anasayfa.json");
            var responseModel = JsonConvert.DeserializeObject<ApiResponseModel>(result);

            var newsList = JsonConvert.DeserializeObject<List<AllNewsDetail>>(responseModel.data.ToString());
			var pagingNews = newsList.SelectMany(section => section.ItemList);
            ViewBag.Categories= newsList.SelectMany(section => section.ItemList).Where(x => x.Category != null && x.Category.Title!= "\"").Select(x => x.Category.Title).Distinct().ToList();
            var count = pagingNews.Count();
			var model = new PageViewModel<ItemList>(pagingNews.Skip((page - 1) * pageSize).Take(pageSize).ToList(), count, page, pageSize);
			return View(model);
		}
    }
}
