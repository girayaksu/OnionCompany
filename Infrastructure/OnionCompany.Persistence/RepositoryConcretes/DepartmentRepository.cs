using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using OnionCompany.Persistence.ContextClasses;

namespace OnionCompany.Persistence.RepositoryConcretes
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(MyContext context) : base(context)
        {
        }
    }
}


