using Blog.Core.Entities;
using Blog.Core.Interfaces.Repositories;
using Blog.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Infrastructure.Data.Repository.EF
{
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ArticleContext _dbContext;

        public EFRepository(ArticleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            try
            {
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(Guid Id)
        {
            return _dbContext.Set<T>().Find(Id);
        }

        public bool Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            try
            {
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
