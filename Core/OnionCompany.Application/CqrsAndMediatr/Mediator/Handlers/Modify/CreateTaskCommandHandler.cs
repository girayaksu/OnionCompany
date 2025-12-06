using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand>
    {
        private readonly ITaskRepository _repository;
        public CreateTaskCommandHandler(ITaskRepository repository) { _repository = repository; }
        public async System.Threading.Tasks.Task Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new OnionCompany.Domain.Entities.Task
            {
                Title = request.Title,
                Description = request.Description,
                DueDate = request.DueDate,
                IsCompleted = request.IsCompleted,
                ProjectId = request.ProjectId,
                AssignedToEmployeeId = request.AssignedToEmployeeId,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            });
        }
    }
}




