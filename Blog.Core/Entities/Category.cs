using Blog.Core.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<CategoryArticle> CategoryArticles { get; set; }
    }
}
