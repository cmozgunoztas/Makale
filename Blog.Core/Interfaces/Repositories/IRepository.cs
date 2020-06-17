using Blog.Core.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : IEntity
    {
        List<T> GetAll();
        T GetById(Guid Id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        void Dispose();
    }
}
