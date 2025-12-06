using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetDepartmentQueryHandler : IRequestHandler<GetDepartmentQuery, List<GetDepartmentQueryResult>>
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public GetDepartmentQueryHandler(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<List<GetDepartmentQueryResult>> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            var departments = await _repository.GetAllAsync();
            return _mapper.Map<List<GetDepartmentQueryResult>>(departments);
        }
    }
}



