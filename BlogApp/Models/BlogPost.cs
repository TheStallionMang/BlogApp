using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BlogApp.Models
{
    public class BlogPost
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        public int Id { get; set; }
        public string AuthorFK { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }

        public BlogPost()
        {
            //_userManager = userManager;
            //this.AuthorFK = _userManager.GetUserId(HttpContext.User);
            //var userId = hca.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //AuthorFK = User.Name;
            DatePosted = DateTime.UtcNow;
            LastUpdated = DatePosted;
        }
    }
}
