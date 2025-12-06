using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class RemoveProjectCommandHandler : IRequestHandler<RemoveProjectCommand>
    {
        private readonly IProjectRepository _repository;
        public RemoveProjectCommandHandler(IProjectRepository repository) { _repository = repository; }
        public async System.Threading.Tasks.Task Handle(RemoveProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(project);
        }
    }
}




