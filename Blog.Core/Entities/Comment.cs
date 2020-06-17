using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Entities
{
    public class Comment : BaseEntity
    {
        public string Contents { get; set; }
        public DateTime CreateDate { get; set; }
        public int LikeCount { get; set; }
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
