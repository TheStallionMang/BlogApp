using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlogApp.Data;
using BlogApp.Models;
using Microsoft.AspNetCore.Identity;

namespace BlogApp.Pages.BlogPosts
{
    public class CreateModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly BlogApp.Data.ApplicationDbContext _context;

        public CreateModel(BlogApp.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult OnGet()
        {
            //ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            BlogPost.AuthorFK = _userManager.GetUserId(HttpContext.User);
            _context.BlogPost.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}