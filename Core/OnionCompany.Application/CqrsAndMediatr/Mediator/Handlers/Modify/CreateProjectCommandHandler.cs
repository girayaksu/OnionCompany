using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand>
    {
        private readonly IProjectRepository _repository;
        public CreateProjectCommandHandler(IProjectRepository repository) { _repository = repository; }
        public async System.Threading.Tasks.Task Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Project
            {
                Name = request.Name,
                Description = request.Description,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            });
        }
    }
}




