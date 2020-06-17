using Blog.Core.Entities;
using Blog.Core.Interfaces.Repositories;
using Blog.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Data.Repository.EF
{
    public class AuthorRepository : EFRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ArticleContext dbContext) : base(dbContext)
        {
        }
    }
}
