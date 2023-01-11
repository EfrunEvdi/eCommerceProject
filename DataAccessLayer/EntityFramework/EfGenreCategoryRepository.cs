using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGenreCategoryRepository : GenericRepository<GenreCategory>, IGenreCategoryDal
    {
        public List<GenreCategory> GenreCategoriesListBySub()
        {
            using (var c = new Context())
            {
                return c.GenreCategories.Include(x => x.SubCategory).ToList();
            }
        }
    }
}
