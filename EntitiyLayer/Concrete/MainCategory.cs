using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryID { get; set; }
        public string NameMainCategory { get; set; }
        public string ImageUrlMainCategory { get; set; }
        public List<SubCategory> SubCategories { get; set; }
       
    }
}
