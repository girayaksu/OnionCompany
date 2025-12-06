using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using System.Threading;


namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand>
    {
        private readonly IDepartmentRepository _repository;

        public CreateDepartmentCommandHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async System.Threading.Tasks.Task Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Department
            {
                Name = request.Name,
                Location = request.Location,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            });
        }
    }
}



