using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Blog_ALV.Models
{
    public class Event
    {
        public Event()
        {
            this.IsPublic = true;
            this.StartDateTime = true;
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public bool IsPublic { get; private set; }

        [Required]
        public bool StartDateTime { get; private set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public TimeSpan? Duration { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public string Description { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }
        public HashSet<Comment> Comments { get; private set; }
    }
}