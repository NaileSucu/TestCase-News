using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace NewsUI.Helpers
{
    public class ApiConsumer
    {
        public static  string Get<T>(string baseurl)
        {
            var handler = new HttpClientHandler();
            var resultmodel = "";
            using (var client = new HttpClient(handler))
            {
                try
                {
                    client.BaseAddress = new Uri(baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = client.GetAsync("").Result;

                    try
                    {
                        resultmodel = Res.Content.ReadAsStringAsync().Result;
                    }
                    catch
                    {
                        resultmodel = "";
                    }
                    return resultmodel;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
    public class ApiResponseModel
    {
        public object ErrorCode { get; set; }
        public object errorMessage { get; set; }
        public object data { get; set; }


    }



}
