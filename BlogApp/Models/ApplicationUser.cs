using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp
{
    public class ApplicationUser : IdentityUser
    {
        /*public string UserName { get; set; }*/
        public DateTime DateJoined { get; set; }

        public ApplicationUser()
        {
            this.DateJoined = DateTime.UtcNow;
        }
    }
}
