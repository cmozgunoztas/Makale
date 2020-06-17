using Blog.Core.Entities;
using Blog.Core.Interfaces.Repositories;
using Blog.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Data.Repository.EF
{
    public class ArticleRepository : EFRepository<Article>, IArticleRepository
    {
        public ArticleRepository(ArticleContext dbContext) : base(dbContext)
        {
        }
    }
}
