using AutoMapper;
using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Queries;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Results;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, GetTaskByIdQueryResult>
    {
        private readonly ITaskRepository _repository;
        private readonly IMapper _mapper;
        public GetTaskByIdQueryHandler(ITaskRepository repository, IMapper mapper) { _repository = repository; _mapper = mapper; }
        public async System.Threading.Tasks.Task<GetTaskByIdQueryResult> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetTaskByIdQueryResult>(task);
        }
    }
}




