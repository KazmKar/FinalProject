using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint 
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity iplemente eden bir nesne olabir
    //new() : new'lene olabilir
    public interface IEntityRepository<T> where T: class, IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
