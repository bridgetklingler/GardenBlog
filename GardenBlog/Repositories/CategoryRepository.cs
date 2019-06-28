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

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
