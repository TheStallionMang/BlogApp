using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class BlogAppUser
    {
        public int Id { get; set; }
        public string IdentityFK { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }

        public BlogAppUser()
        {
            DateJoined = DateTime.UtcNow;
        }
    }
}
