using Blog.Core.Entities;
using Blog.Core.Interfaces.Repositories;
using Blog.Core.Interfaces.Services;
using Blog.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public ServiceResult<List<Article>> GetList()
        {
            var result = new ServiceResult<List<Article>>();
            var data = _articleRepository.GetAll();
            if (data == null)
            {
                result.Error("No data found");
            }
            else
            {
                result.Success(data);
            }
            return result;
        }
        public ServiceResult<Article> GetById(Guid articleId)
        {
            var result = new ServiceResult<Article>();
            var data = _articleRepository.GetById(articleId);
            if (data == null)
            {
                result.Error("No data found");
            }
            else
            {
                result.Success(data);
            }
            return result;
        }
        public ServiceResult<bool> Delete(Guid articleId)
        {
            var result = new ServiceResult<bool>();
            var data = _articleRepository.GetById(articleId);
            var isSuccess = _articleRepository.Delete(data);
            if (isSuccess == true)
            {
                result.IsSuccess = true;
            }
            else
            {
                result.IsSuccess = false;
            }
            return result;
        }
        public ServiceResult<bool> Update(Article article)
        {
            var result = new ServiceResult<bool>();
            var isSucces = _articleRepository.Update(article);
            if (isSucces)
            {
                result.IsSuccess = true;
            }
            else
            {
                result.IsSuccess = false;
            }
            return result;

        }
        public ServiceResult<bool> Insert(Article article)
        {
            var result = new ServiceResult<bool>();
            var isSuccess = _articleRepository.Insert(article);
            if (isSuccess)
            {
                result.IsSuccess = true;
            }
            else
            {
                result.IsSuccess = false;
            }
            return result;
        }


    }
}
