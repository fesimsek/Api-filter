using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebApplication5;

namespace WebApplication5.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        //IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Func<T, bool> SimpleComparison<T>(List<Filter> codes);

    }
}