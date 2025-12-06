using Microsoft.Extensions.DependencyInjection;
using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Persistence.RepositoryConcretes;

namespace OnionCompany.Persistence.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
        }
    }
}
