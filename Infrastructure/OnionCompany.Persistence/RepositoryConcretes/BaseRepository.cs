using Microsoft.EntityFrameworkCore;
using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Interfaces;
using OnionCompany.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace OnionCompany.Persistence.RepositoryConcretes
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly MyContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async System.Threading.Tasks.Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async System.Threading.Tasks.Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task UpdateAsync(T oldEntity, T newEntity)
        {
            _dbSet.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            await SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
           return _dbSet.Where(exp);
        }
    }
}
