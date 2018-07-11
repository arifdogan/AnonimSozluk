using AnonimSozluk.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnonimSozluk.DataAccessLayer.EntityFramework
{
    public class Repository<T> : RepositoryBase where T : class
    {
        DbSet<T> objectSet;

        public Repository()
        {
            objectSet = context.Set<T>();
        }

        public List<T> List()
        {
            return objectSet.ToList();
        }

        public IQueryable<T> ListQueryable()
        {
            return objectSet.AsQueryable<T>();
        }

        public int Insert(T obj)
        {
            objectSet.Add(obj);
            if (obj is EntityBase)
            {
                EntityBase tempObj = obj as EntityBase;
                tempObj.CreatedDate = DateTime.Now;
            }
            return Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
