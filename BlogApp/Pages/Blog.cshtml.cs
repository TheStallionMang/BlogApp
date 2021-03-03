using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApp.Data;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlogApp.Pages
{
    public class BlogModel : PageModel
    {
        private readonly BlogApp.Data.ApplicationDbContext _context;
        //private readonly IdentityDbContext _icontext;

        public BlogModel(BlogApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get; set; }
        public IList<IdentityUser> IdentityUser { get; set; }
        public string id;

        /*
        public void OnGet()
        {
        }
        */

        public async Task OnGetAsync([FromQuery(Name = "id")] string idQuery)
        {
            id = idQuery;
            BlogPost = await _context.BlogPost.ToListAsync();
            IdentityUser = await _context.IdentityUser.ToListAsync();
        }
    }
}
