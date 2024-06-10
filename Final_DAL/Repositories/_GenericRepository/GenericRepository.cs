using Final_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL.Repositories._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T>  where T : class
    {
        public readonly DbSet<T> _dbset;
        public readonly AirplaneSystemContext _airplaneSystemContext;

        public GenericRepository(AirplaneSystemContext airplaneSystemContext)
        {

            _airplaneSystemContext = airplaneSystemContext;
            _dbset = _airplaneSystemContext.Set<T>();
        }
        public T Add(T T)
        {
            var result = _dbset.Add(T);
            _airplaneSystemContext.SaveChanges();
            return T;
        }

        #region Get

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }
        public T GetById(int id)
        {
            return _dbset.Find(id);
        }
        #endregion


        public T Update(T T)
        {
            _dbset.Update(T);
            try
            {
                _airplaneSystemContext.SaveChanges();
            }
            catch
            {
            }
            return T;
        }
        public Boolean Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                Delete(entity);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean Delete(T T)
        {
            _dbset.Remove(T);
            try
            {
                _airplaneSystemContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
