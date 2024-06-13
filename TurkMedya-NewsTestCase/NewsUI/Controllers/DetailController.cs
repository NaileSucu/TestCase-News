using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NewsUI.Helpers;
using Newtonsoft.Json;

namespace NewsUI.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            var result = Helpers.ApiConsumer.Get<string>(@"https://www.turkmedya.com.tr/detay.json");
            var responseModel = JsonConvert.DeserializeObject<ApiResponseModel>(result);

            var newsList = JsonConvert.DeserializeObject<DetailNew>(responseModel.data.ToString());
            return View(newsList);
        }
    }
}
