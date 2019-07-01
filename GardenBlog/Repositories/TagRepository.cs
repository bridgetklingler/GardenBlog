using GardenBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenBlog.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags;
        }

        public Tag GetById(int id)
        {
            return db.Tags.Single(t => t.TagId == id);
        }


        //unused
        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }
    }
}
