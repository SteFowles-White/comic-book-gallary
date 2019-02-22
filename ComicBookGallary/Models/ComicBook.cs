using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallary.Models
{
    public class ComicBook
    {
        public int Id { get; set;}
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }

    }
}