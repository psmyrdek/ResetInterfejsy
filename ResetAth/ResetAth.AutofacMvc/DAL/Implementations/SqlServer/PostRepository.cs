using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResetAth.AutofacMvc.DAL.Implementations.SqlServer
{
    public class PostRepository : IPostRepository
    {
        public IEnumerable<Models.Post> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.Posts.ToList<Post>();
            }
        }

        public Models.Post GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                return db.Posts.Single<Post>(x => x.Id == id);
            }
        }

        public void Add(Post post)
        {
            using (var db = new AppDbContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }

        public void Delete(Models.Post post)
        {
            using (var db = new AppDbContext())
            {
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }
    }
}