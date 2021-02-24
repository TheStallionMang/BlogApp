using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlogApp.Data;
using BlogApp.Models;

namespace BlogApp.Pages.BlogPosts
{
    public class IndexModel : PageModel
    {
        private readonly BlogApp.Data.ApplicationDbContext _context;

        public IndexModel(BlogApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get;set; }

        public async Task OnGetAsync()
        {
            BlogPost = await _context.BlogPost.ToListAsync();
        }
    }
}
