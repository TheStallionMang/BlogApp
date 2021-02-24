using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class BlogPost
    {
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
            DatePosted = DateTime.UtcNow;
            LastUpdated = DatePosted;
        }
    }
}
