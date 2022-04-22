﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic Constraint
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);   
        T Get(Expression<Func<T, bool>> filter);
       // List<T> GetAllByCategory(int categoryId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
