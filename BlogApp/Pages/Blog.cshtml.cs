using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApp.Data;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Pages
{
    public class BlogModel : PageModel
    {
        private readonly BlogApp.Data.ApplicationDbContext _context;

        public BlogModel(BlogApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get; set; }

        /*
        public void OnGet()
        {
        }
        */

        public async Task OnGetAsync()
        {
            BlogPost = await _context.BlogPost.ToListAsync();
        }
    }
}
