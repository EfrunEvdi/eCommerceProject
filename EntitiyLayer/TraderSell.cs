using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class TraderSell //Satış yapan kişi
    {
        [Key]
        public int TraderSellID { get; set; }
        public string TraderSellUserName { get; set; }
        public string DescriptionTraderSell { get; set; } 
        public string ImageUrlTraderSell { get; set; }  //Profil foto
        public string PhoneNumberTraderSell { get; set; }
        public DateTime DateTraderSell { get; set; }
        public string MailTraderSell { get; set; }
        public string IBANTraderSell { get; set; }
        public string Address1TraderSell { get; set; }
        public string Address2TraderSell { get; set; }
        public string Address3TraderSell { get; set; }

        //Product tablosuna id vereceğiz
    }
}
