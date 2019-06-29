using GardenBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }


        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.CategoryId == id);
        }


        //stretch
        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
