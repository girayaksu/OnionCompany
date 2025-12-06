using OnionCompany.Application.DTOClasses;
using OnionCompany.Application.DTOInterfaces;
using OnionCompany.Domain.Entities;
using OnionCompany.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionCompany.Application.ManagerInterfaces
{
    public interface IManager<T, U> where T : class, IDto where U : class, IEntity
    {

        System.Threading.Tasks.Task<List<T>> GetAllAsync();
        System.Threading.Tasks.Task<T> GetByIdAsync(int id);
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetUpdateds();


        System.Threading.Tasks.Task CreateAsync(T entity);
        System.Threading.Tasks.Task UpdateAsync(T entity);
        System.Threading.Tasks.Task<string> SoftDeleteAsync(int id);
        System.Threading.Tasks.Task<string> HardDeleteAsync(int id);
    }
}
