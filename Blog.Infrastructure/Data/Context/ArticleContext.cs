using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Data.Context
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryArticle> CategoryArticles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryArticle>().HasKey(ca => new { ca.ArticleId, ca.CategoryId });
        }
    }
}
