using Blog.Core.Entities;
using Blog.Core.Interfaces.Repositories;
using Blog.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Data.Repository.EF
{
    public class CommentRepository : EFRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ArticleContext dbContext) : base(dbContext)
        {
        }
    }
}
