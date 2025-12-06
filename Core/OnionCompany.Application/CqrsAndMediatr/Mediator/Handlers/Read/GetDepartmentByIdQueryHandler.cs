using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, GetDepartmentByIdQueryResult>
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public GetDepartmentByIdQueryHandler(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<GetDepartmentByIdQueryResult> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetDepartmentByIdQueryResult>(department);
        }
    }
}



