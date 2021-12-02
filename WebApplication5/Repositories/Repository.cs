using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.DbOperations;
using WebApplication5;
using System.Threading.Tasks;
using System.Linq.Expressions;

using System.Linq.Dynamic.Core;
using System.Reflection;
using static WebApplication5.Filter;

namespace WebApplication5.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApiDbContext context;
        private DbSet<T> entities;

        public Repository(ApiDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        //public IEnumerable<T> GetAll()
        //{
        //    return entities.AsEnumerable();
        //}
        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            context.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        


    }   
}