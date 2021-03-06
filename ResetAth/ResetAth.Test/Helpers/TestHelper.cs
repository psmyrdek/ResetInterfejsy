﻿using Moq;
using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetAth.Test.Helpers
{
    public static class TestHelper
    {
        public static IPostRepository GetPostRepository()
        {
            List<Post> AllPosts = new List<Post>
            {
                new Post { Id = 0, Title = "Post 1 Title", Content = "Some content", PathToImage = "1 ImagePath"},
                new Post { Id = 1, Title = "Post 2 Title", Content = "Some content", PathToImage = "2 ImagePath"},
                new Post { Id = 2, Title = "Post 3 Title", Content = "Some content", PathToImage = "3 ImagePath"}
            };

            var mock = new Mock<IPostRepository>();

            mock.Setup(m => m.GetAll()).Returns(AllPosts);

            mock.Setup(m => m.GetById(It.IsAny<int>()))
                .Returns((int i) => AllPosts.SingleOrDefault(x => x.Id == i));

            mock.Setup(m => m.Add(It.IsAny<Post>())).Callback((Post post) =>
            {
                AllPosts.Add(post);
            });

            return mock.Object;
        }
    }
}
