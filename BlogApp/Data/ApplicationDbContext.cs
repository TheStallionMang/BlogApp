using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Models;
using Microsoft.AspNetCore.Identity;

namespace BlogApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BlogApp.Models.BlogPost> BlogPost { get; set; }
        public DbSet<BlogApp.Models.BlogAppUser> BlogAppUser { get; set; }
        public DbSet<IdentityUser>  IdentityUser { get; set; }
    }
}
