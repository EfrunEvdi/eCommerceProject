using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GenreCategory
    {
        [Key]
        public int GenreCategoryID { get; set; }
        public string NameGenreCategory { get; set; }
        public string ImageUrlGenreCategory { get; set; }

        public int SubCategoryID { get; set; }  
        public SubCategory SubCategory { get; set; }
        public List<Product> Products { get; set; }

        //SubCategory e bağlanacak
    }
}
