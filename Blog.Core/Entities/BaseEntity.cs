using Blog.Core.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}
