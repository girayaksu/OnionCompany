using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, GetProjectByIdQueryResult>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;
        public GetProjectByIdQueryHandler(IProjectRepository repository, IMapper mapper) { _repository = repository; _mapper = mapper; }
        public async System.Threading.Tasks.Task<GetProjectByIdQueryResult> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProjectByIdQueryResult>(project);
        }
    }
}




