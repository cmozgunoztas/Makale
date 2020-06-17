using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Entities
{
    public class CategoryArticle
    {
        public Guid CategoryId { get; set; }
        public Guid ArticleId { get; set; }
        public Category Category { get; set; }
        public Article Article { get; set; }
    }
}
