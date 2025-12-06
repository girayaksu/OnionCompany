using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, List<GetProjectQueryResult>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;
        public GetProjectQueryHandler(IProjectRepository repository, IMapper mapper) { _repository = repository; _mapper = mapper; }
        public async System.Threading.Tasks.Task<List<GetProjectQueryResult>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            var projects = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProjectQueryResult>>(projects);
        }
    }
}




