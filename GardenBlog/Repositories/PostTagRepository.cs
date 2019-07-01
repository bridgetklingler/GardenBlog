using GardenBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Repositories
{
    public class PostTagRepository : IRepository<PostTag>
    {
        private BlogContext db;

        public PostTagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(PostTag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostTag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(PostTag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostTag> GetAll()
        {
            throw new NotImplementedException();
        }

        public PostTag GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
