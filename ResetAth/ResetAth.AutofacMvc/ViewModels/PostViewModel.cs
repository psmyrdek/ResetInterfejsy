using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResetAth.AutofacMvc.ViewModels
{
    public class PostViewModel
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string PathToImage { get; set; }
    }
}