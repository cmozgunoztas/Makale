using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int LikeCount { get; set; }
        public Guid AuthorId { get; set; }
        //public Authors Author { get; set; }
        //public ICollection<CategoryArticles> CategoryArticles { get; set; }
    }
}
