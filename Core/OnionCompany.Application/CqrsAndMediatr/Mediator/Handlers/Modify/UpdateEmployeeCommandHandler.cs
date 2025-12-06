using MediatR;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Commands;
using OnionCompany.Contract.RepositoryInterfaces;
using System.Threading;

namespace OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Modify
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IEmployeeRepository _repository;
        public UpdateEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async System.Threading.Tasks.Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repository.GetByIdAsync(request.Id);
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.DepartmentId = request.DepartmentId;
            employee.UpdatedDate = DateTime.Now;
            employee.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();
        }
    }
}