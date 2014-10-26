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
using ResetAth.AutofacMvc.ViewModels;
using System.Diagnostics;

namespace ResetAth.Test
{
    [TestClass]
    public class PostControllersTests
    {
        [TestMethod]
        public void Index_Method_Should_Return_All_Posts()
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
        public void Single_Method_Should_Return_Correct_Post()
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

        [TestMethod]
        public void Add_Method_Should_Increase_Data_Source_Size()
        {
            //Arrange
            IPostRepository repo = TestHelper.GetPostRepository();
            PostController controller = new PostController(repo);

            //Act
            var resultBefore = controller.Index() as ViewResult;
            IEnumerable<Post> postsBefore = resultBefore.Model as IEnumerable<Post>;
            int sizeBefore = postsBefore.Count<Post>();

            controller.Add(new PostViewModel()
            {
                Title = It.IsAny<string>(),
                Content = It.IsAny<string>(),
                PathToImage = It.IsAny<string>()
            });

            var resultAfter = controller.Index() as ViewResult;
            IEnumerable<Post> postsAfter = resultAfter.Model as IEnumerable<Post>;
            int sizeAfter = postsAfter.Count<Post>();

            //Assert
            Assert.IsTrue(sizeAfter == sizeBefore + 1);
        }
    }
}
