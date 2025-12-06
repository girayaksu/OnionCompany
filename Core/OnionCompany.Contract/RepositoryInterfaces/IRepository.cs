using OnionCompany.Domain.Entities;
using OnionCompany.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnionCompany.Contract.RepositoryInterfaces
{
    public interface IRepository<T> where T:class,IEntity
    {

        System.Threading.Tasks.Task<List<T>> GetAllAsync();
        System.Threading.Tasks.Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> exp);

        System.Threading.Tasks.Task CreateAsync(T entity);
        System.Threading.Tasks.Task UpdateAsync(T oldEntity,T newEntity);
        System.Threading.Tasks.Task DeleteAsync(T entity);
        System.Threading.Tasks.Task<int> SaveChangesAsync();
    }
}
