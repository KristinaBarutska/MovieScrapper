using MovieScrapper.Data;
using MovieScrapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScrapper.Business
{
    public class CategoryService
    {
        public IEnumerable<MovieCategory> GetAll()
        {
            var repo = new CategoryRepository();
            return repo.GetAll();
        }
    }
}
