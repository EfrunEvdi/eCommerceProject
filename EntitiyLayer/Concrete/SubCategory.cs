using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string NameSubCategory { get; set; }
        public string ImageUrlSubCategory { get; set; }

        public List<GenreCategory> GenreCategories { get; set; }


        public int MainCategoryID { get; set; } 
        public MainCategory MainCategory { get; set; }
        // MainCategory e bağlanacak
    }
}
