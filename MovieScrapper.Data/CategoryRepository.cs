using MovieScrapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScrapper.Data
{
    public class CategoryRepository
    {
        public IEnumerable<MovieCategory> GetAll()
        {

            using (var ctx = new MovieContext())
            {
                var databaseCategory = ctx.MovieCaterogries.Include("Movies").ToList();
                return databaseCategory;
            }
        }
    }
}
