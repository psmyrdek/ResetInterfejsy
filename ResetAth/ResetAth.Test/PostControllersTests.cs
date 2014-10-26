using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;
using ResetAth.AutofacMvc.Controllers;
using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResetAth.Test.Helpers;

namespace ResetAth.Test
{
    [TestClass]
    public class PostControllersTests
    {
        [TestMethod]
        public void IndexMethodShouldReturnAllPosts()
        {
            //Arrange
            IPostRepository repo = TestHelper.GetPostRepository();
            PostController controller = new PostController(repo);

            //Act
            var result = controller.Index() as ViewResult;
            IEnumerable<Post> posts = result.Model as IEnumerable<Post>;

            //Assert
            Assert.IsTrue(posts.Count() == 3);
        }

        [TestMethod]
        public void SingleMethodShouldReturnCorrectPost()
        {
            //Arrange
            IPostRepository repo = TestHelper.GetPostRepository();
            PostController controller = new PostController(repo);

            //Act
            var result = controller.Single(1) as ViewResult;
            Post post = result.Model as Post;

            //Assert
            Assert.IsTrue(post.Id == 1 && post.Title == "Post 2 Title");
        }
    }
}
