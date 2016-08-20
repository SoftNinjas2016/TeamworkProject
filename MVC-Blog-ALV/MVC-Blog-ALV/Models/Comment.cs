using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Blog_ALV.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public Post Post { get; set; }

        [Required]
        public DateTime Date { get; private set; }

        public string AuthorId { get; private set; }

        public virtual ApplicationUser Author { get; private set; }

        public int EventId { get; private set; }

        public virtual Event Event { get; set; }
    }
}