using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using OnionCompany.Persistence.ContextClasses;

namespace OnionCompany.Persistence.RepositoryConcretes
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MyContext context) : base(context)
        {
        }
    }
}


