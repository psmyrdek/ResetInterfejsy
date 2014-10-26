using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResetAth.AutofacMvc.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PathToImage { get; set; }
        public string Content { get; set; }
    }
}