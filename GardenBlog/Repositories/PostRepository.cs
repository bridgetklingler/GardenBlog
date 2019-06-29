using GardenBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Edit(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(p => p.PostId == id);
        }
    }
}
