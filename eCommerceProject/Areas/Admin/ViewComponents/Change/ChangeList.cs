using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;

namespace eCommerceProject.Areas.Admin.ViewComponents.Change
{
    public class ChangeList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ////string api = "76b811e5575eb7ae66b77c82";
            //string connection = "https://v6.exchangerate-api.com/v6/76b811e5575eb7ae66b77c82/latest/USD";


            //XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(connection);
            //XDocument document = XDocument.Load(connection);
            //ViewBag.usd = document.Descendants("conversion_rates").ElementAt(0).Attribute("TRY").Value;

            ////var httpClient = new HttpClient();
            ////var responseMessage = await httpClient.GetAsync("https://v6.exchangerate-api.com/v6/76b811e5575eb7ae66b77c82/latest/USD");
            ////var jsonString = await responseMessage.Content.ReadAsStringAsync();
            ////var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View();
        }
    }
}
