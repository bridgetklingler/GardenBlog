using GardenBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Repositories
{
    public class PostTagRepository : IRepository<Post>
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

        public void Delete(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Post obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
