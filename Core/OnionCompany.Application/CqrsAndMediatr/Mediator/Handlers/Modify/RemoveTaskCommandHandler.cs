using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class RemoveTaskCommandHandler : IRequestHandler<RemoveTaskCommand>
    {
        private readonly ITaskRepository _repository;
        public RemoveTaskCommandHandler(ITaskRepository repository) { _repository = repository; }
        public async System.Threading.Tasks.Task Handle(RemoveTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(task);
        }
    }
}




