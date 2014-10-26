using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.Models;
using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResetAth.AutofacMvc.DAL.Implementations.MySql
{
    public class MySqlPostRepository : IPostRepository
    {
        public IEnumerable<Models.Post> GetAll()
        {
            var db = Database.Open();
            IEnumerable<Post> posts = db.post.All().Cast<Post>();
            return posts;
        }

        public Models.Post GetById(int id)
        {
            var db = Database.Open();
            Post post = db.post.FindById(id);
            return post;
        }

        public void Add(Models.Post post)
        {
            var db = Database.Open();
            db.post.Insert(Title: post.Title, Content: post.Content, PathToImage: post.PathToImage);
        }

        public void Delete(Models.Post post)
        {
            var db = Database.Open();
            db.post.DeleteById(post.Id);
        }
    }
}