using Blog.Core.Entities;
using Blog.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Interfaces.Services
{
    public interface IArticleService
    {
        ServiceResult<List<Article>> GetList();
        ServiceResult<Article> GetById(Guid articleId);
        ServiceResult<bool> Delete(Guid articleId);
        ServiceResult<bool> Update(Article article);
        ServiceResult<bool> Insert(Article article);
    }
}
