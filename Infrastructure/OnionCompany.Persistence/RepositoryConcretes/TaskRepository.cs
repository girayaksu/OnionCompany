using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Persistence.ContextClasses;

namespace OnionCompany.Persistence.RepositoryConcretes
{
    public class TaskRepository : BaseRepository<OnionCompany.Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(MyContext context) : base(context)
        {
        }
    }
}


