using MediaNote.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MediaNote.DataLayer.Service
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MediaNoteEntities _db;
        private DbSet<T> _dbSet;
        public GenericRepository(MediaNoteEntities db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }


        public IEnumerable<T> GetAll
            (Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> Order = null,
            string includs = null)
        {
            IQueryable<T> data = _dbSet;
            if(where != null)
            {
                data = data.Where(where);
            }
            if(Order != null)
            {
                data = Order(data);
            }
            if (includs != null)
            {
                foreach(var item in includs.Split(','))
                {
                    data = data.Include(item);
                }
            }
            return data.ToList();
        }


        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }


        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }


        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Delete(object id)
        {
            Delete(GetById(id));
        }


        

    }
}
