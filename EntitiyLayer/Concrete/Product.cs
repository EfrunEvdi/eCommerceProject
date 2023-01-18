using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int? SellTraderID { get; set; }
        public int? BuyTraderID { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string BrandProduct { get; set; }
        public string SizeProduct { get; set; } 
        public Decimal PriceProduct { get; set; }
        public DateTime DateProduct { get; set; }
        public bool StatusProduct { get; set; }
        public string ImageUrl1Product { get; set; }
        public string ImageUrl2Product { get; set; }
        public string ImageUrl3Product { get; set; }
        public string ImageUrl4Product { get; set; }
        public string ImageUrl5Product { get; set; }
        public string ImageUrl6Product { get; set; }
        public int GenreCategoryID { get; set; }
        public GenreCategory GenreCategory { get; set; }
        public List<Comment> Comments { get; set; }
        
        public Trader SellTrader { get; set; }
        public Trader BuyTrader { get; set; }

        //TraderSell ve TraderBuyID bağlanacak
        //CategoryMainID eklenecek
        //CategoryGenre eklenecek
        //CategorySub eklenecek

    }
}
