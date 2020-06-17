using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Entities;
using Blog.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public IActionResult GetArticles()
        {
            var data = _articleService.GetList();
            return Ok(data);
        }
        [HttpGet]
        [Route("/api/GetById")]
        public ActionResult GetArticleById(Guid articleId)
        {
            var data = _articleService.GetById(articleId);
            return Ok(data);
        }
        [HttpPost]
        public ActionResult AddArticle(Article article)
        {
            var data = _articleService.Insert(article);
            return Ok(data);
        }
        [HttpPut]
        public ActionResult UpdateArticle(Article article)
        {
            var data = _articleService.Update(article);
            return Ok(data);
        }
        [HttpDelete]
        public ActionResult DeleteArticle(Guid articleId)
        {
            var data = _articleService.Delete(articleId);
            return Ok(data);
        }
    }
}
