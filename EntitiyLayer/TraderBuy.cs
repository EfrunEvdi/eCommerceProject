using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class TraderBuy
    {
        [Key]
        public int TraderBuyID { get; set; }
        public string TraderBuyUserName { get; set; }
        public string DescriptionTraderBuy { get; set; }
        public string ImageUrlTraderBuy { get; set; }
        public string PhoneNumberTraderBuy { get; set; }
        public DateTime DateTraderBuy { get; set; } 
        public string MailTraderBuy { get; set; }
        public string IBANTraderBuy { get; set; }
        public string Address1TraderBuy { get; set; }
        public string Address2TraderBuy { get; set; }
        public string Address3TraderBuy { get; set; }


        //Product tablosuna id vereceğiz
    }
}
