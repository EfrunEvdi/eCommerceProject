using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Trader
    {
        [Key]
        public int TraderID { get; set; }
        public string TraderUserName { get; set; }
        public string DescriptionTrader { get; set; }
        public string ImageUrlTrader { get; set; }
        public string PhoneNumberTrader { get; set; }
        public string MailTrader { get; set; }
        public string IBANTrader { get; set; }
        public string Address1Trader { get; set; }
        public string Address2Trader { get; set; }
        public string Address3Trader { get; set; }

        //public List<Trader> Traders { get; set; }
        public virtual ICollection <Product> TraderSeller { get; set; }
        public virtual ICollection <Product> TraderBuyer { get; set; }

        //Product tablosuna id vereceğiz
    }
}
