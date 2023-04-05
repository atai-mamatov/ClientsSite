using ClientsSite.Data.Database;
using ClientsSite.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsSite.Data.Repository
{
    public class Repository<T> : IRepository<T> 
        where T : BaseEntity
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T Add(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if(dbSet == default(DbSet<T>))
                return default(T);

            T result = dbSet.Add(item).Entity;
            _context.SaveChanges();

            return result;
        }

        public List<T> AddAll(IEnumerable<T> items)
        {
            List<T> result = new List<T>();

            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(List<T>);

            foreach (T item in items)
            {
                T entity = dbSet.Add(item).Entity;
                result.Add(entity);
            }

            _context.SaveChanges();
            return result;
        }

        public void Delete(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return;

            dbSet.Remove(item);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(List<T>);

            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return default(T);

            T item = dbSet
                .FirstOrDefault(obj => obj.Id == id);

            return item;
        }

        public void Update(T item)
        {
            DbSet<T> dbSet = _context.Set<T>();

            if (dbSet == default(DbSet<T>))
                return;

            dbSet.Update(item);

            _context.SaveChanges();
        }

    }
}
