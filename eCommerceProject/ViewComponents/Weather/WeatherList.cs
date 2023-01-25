using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace eCommerceProject.ViewComponents.Weather
{
    public class WeatherList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "0be77b477064af1c5eb2da55c4cc3b84";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
