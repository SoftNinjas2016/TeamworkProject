using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVC_Blog_ALV.Models
{
    public class PostDetailsViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Author_Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public static Expression<Func<Post, PostDetailsViewModel>> ViewModel
        {
            get
            {
                return p => new PostDetailsViewModel()
                {
                    Id = p.Id,
                    Date = p.Date,
                    Author_Id = p.Author_Id,
                    Title = p.Title,
                    Body = p.Body
                };
            }
        }
    }
}