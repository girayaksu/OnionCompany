using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using OnionCompany.Domain.Entities;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
    {
        private readonly IEmployeeRepository _repository;
        public CreateEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async System.Threading.Tasks.Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Employee
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                DepartmentId = request.DepartmentId,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            });
        }
    }
}