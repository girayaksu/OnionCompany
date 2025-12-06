using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, List<GetTaskQueryResult>>
    {
        private readonly ITaskRepository _repository;
        private readonly IMapper _mapper;
        public GetTaskQueryHandler(ITaskRepository repository, IMapper mapper) { _repository = repository; _mapper = mapper; }
        public async System.Threading.Tasks.Task<List<GetTaskQueryResult>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _repository.GetAllAsync();
            return _mapper.Map<List<GetTaskQueryResult>>(tasks);
        }
    }
}




