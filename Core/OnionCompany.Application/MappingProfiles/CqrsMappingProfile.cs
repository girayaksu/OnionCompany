using AutoMapper;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Domain.Entities;

namespace OnionCompany.Application.MappingProfiles
{
    public class CqrsMappingProfile : Profile
    {
        public CqrsMappingProfile()
        {
            CreateMap<Department, GetDepartmentQueryResult>();
            CreateMap<Department, GetDepartmentByIdQueryResult>();
            
            CreateMap<Employee, GetEmployeeQueryResult>();
            CreateMap<Employee, GetEmployeeByIdQueryResult>();
            
            CreateMap<Project, GetProjectQueryResult>();
            CreateMap<Project, GetProjectByIdQueryResult>();
            
            CreateMap<OnionCompany.Domain.Entities.Task, GetTaskQueryResult>();
            CreateMap<OnionCompany.Domain.Entities.Task, GetTaskByIdQueryResult>();
        }
    }
}


