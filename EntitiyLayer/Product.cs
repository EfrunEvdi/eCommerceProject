using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class Product
    {
        public int ProductID { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string BrandProduct { get; set; }
        public string PriceProduct { get; set; }
        public string StockAmountProduct { get; set; }
        public DateTime DateProduct { get; set; }
        public bool StatusProduct { get; set; }
        public string ImageUrl1Product { get; set; }
        public string ImageUrl2Product { get; set; }
        public string ImageUrl3Product { get; set; }
        public string ImageUrl4Product { get; set; }
        public string ImageUrl5Product { get; set; }
        public string ImageUrl6Product { get; set; }
        public string ImageUrl7Product { get; set; }
        public string ImageUrl8Product { get; set; }
        public string ImageUrl9Product { get; set; }
        public string ImageUrl10Product { get; set; }

        //TraderSell ve TraderBuyID bağlanacak
        //CategoryMainID eklenecek
        //CategoryGenre eklenecek
        //CategorySub eklenecek

    }
}
