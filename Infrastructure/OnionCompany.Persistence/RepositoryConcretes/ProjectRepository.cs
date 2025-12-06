using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using OnionCompany.Persistence.ContextClasses;

namespace OnionCompany.Persistence.RepositoryConcretes
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(MyContext context) : base(context)
        {
        }
    }
}


